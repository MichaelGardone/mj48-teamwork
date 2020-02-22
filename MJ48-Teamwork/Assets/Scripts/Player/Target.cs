using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{

    public float speed = 5f;
    public Camera limiter;
    public float zOffset = 5f;

    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
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

    }
}
