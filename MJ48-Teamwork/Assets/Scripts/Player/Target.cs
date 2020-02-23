using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Target : MonoBehaviour
{

    public float speed = 5f;
    public Camera limiter;
    public float zOffset = 5f;
    public SpriteRenderer render;

    public float timeToMakeReticleGone = 1f;
    float timer = 0f;

    public float timeToBeginFade = 2f;
    float timeToFade = 0f;
    bool startFade = false;

    CommandFamiliar_GameObject cfgo;
    CommandFamiliar_Position cfp;

    private void Awake()
    {
        cfgo = new CommandFamiliar_GameObject();
        cfp = new CommandFamiliar_Position();
    }

    public void RegisterCFP(UnityAction<FamiliarStatus, Vector3> func)
    {
        cfp.AddListener(func);
    }

    void Update()
    {
        // Most definitely a better way to do this than use two timers...
        // TODO: Replace with an enumerator
        if(InputPoll.rightAnalog == Vector2.zero && InputPoll.WestButtonPressed && render.color.a > 0 && startFade == false)
        {
            timeToFade += Time.deltaTime;
            if(timeToFade >= timeToBeginFade)
            {
                timeToFade = 0;
                startFade = true;
            }
        }
        else // we need to reset the targeter
        {
            timeToFade = 0;
            startFade = false;
            if (InputPoll.rightAnalog != Vector2.zero || InputPoll.NorthButtonPressed || InputPoll.SouthButtonPressed || InputPoll.WestButtonPressed)
                render.color = new Color(render.color.r, render.color.g, render.color.b, 1);
        }

        if (startFade)
        {
            timer += Time.deltaTime;
            render.color = new Color(render.color.r, render.color.g, render.color.b, Mathf.Clamp(1 - timer / timeToMakeReticleGone, 0, 1));
            
            if (timer >= timeToMakeReticleGone)
            {
                timer = 0;
                startFade = false;
            }
        }
        
        transform.Translate(new Vector3(1, 1, 0) * InputPoll.rightAnalog * speed * Time.deltaTime, Space.World);

        Vector3 cameraSpacePos = limiter.WorldToScreenPoint(transform.position);

        // General walls
        if (cameraSpacePos.x < 0)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(0, cameraSpacePos.y, zOffset));
        else if (cameraSpacePos.x > limiter.pixelWidth)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(limiter.pixelWidth, cameraSpacePos.y, zOffset));

        if (cameraSpacePos.y < 0)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(cameraSpacePos.x, 0, zOffset));
        else if (cameraSpacePos.y > limiter.pixelHeight)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(cameraSpacePos.x, limiter.pixelHeight, zOffset));

        // Corners
        if (cameraSpacePos.x < 0 && cameraSpacePos.y < 0)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(0, 0, zOffset));

        if (cameraSpacePos.x < 0 && cameraSpacePos.y > limiter.pixelHeight)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(0, limiter.pixelHeight, zOffset));

        if (cameraSpacePos.x > limiter.pixelWidth && cameraSpacePos.y < 0)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(limiter.pixelWidth, 0, zOffset));

        if (cameraSpacePos.x > limiter.pixelWidth && cameraSpacePos.y > limiter.pixelHeight)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(limiter.pixelWidth, limiter.pixelHeight, zOffset));

        if (InputPoll.ResetRightAnalog)
            transform.position = limiter.ScreenToWorldPoint(new Vector3(limiter.pixelWidth / 2, limiter.pixelHeight / 2, zOffset));

        if(InputPoll.WestButtonPressed)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, new Vector3(0, 0, 1), 20f);
            if (hit)
                cfp.Invoke(FamiliarStatus.MOVE, hit.point);
        }

        if (InputPoll.NorthButtonPressed)
            cfp.Invoke(FamiliarStatus.FOLLOW, Vector3.zero);

    }
}
