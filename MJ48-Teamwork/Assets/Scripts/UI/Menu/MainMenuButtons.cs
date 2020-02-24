using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{

    public GameObject arrow;

    public Transform[] position;

    public int curr = 0;

    public InputPoll poll;

    public float sceneFadeDuration = 0.5f;

    public CanvasGroup sceneFadeOverlay;


    public float timerDelay = 0.25f;
    float timer = 0;

    void Start()
    {
        timer += Time.deltaTime;
    }

    void Update()
    {
        Debug.Log(InputPoll.leftAnalog);

        if(timer >= timerDelay)
        {
            if(InputPoll.leftAnalog.y < 0)
            {
                curr++;
                if (curr > 3)
                    curr = 0;
                arrow.transform.position = position[curr].position;
                timer = 0;
                timer += Time.deltaTime;
            }

            if (InputPoll.leftAnalog.y > 0)
            {
                curr--;
                if (curr < 0)
                    curr = 3;
                arrow.transform.position = position[curr].position;
                timer = 0;
                timer += Time.deltaTime;
            }
        }

        if (timer != 0)
            timer += Time.deltaTime;

        if(InputPoll.SouthButtonPressed)
        {
            switch (curr)
            {
                case 0:
                    StartCoroutine(LoadNextWithDelay());
                    break;
                case 1:
                    break;
                case 2:

                    break;
                case 3:
#if UNITY_EDITOR
                    UnityEditor.EditorApplication.isPlaying = false;
#else
                    Application.Quit();
#endif
                    break;
            }
        }
    }

    public IEnumerator LoadNextWithDelay()
    {
        float timer = 0f;

        while (timer < 1f)
        {
            if (sceneFadeOverlay != null)
                sceneFadeOverlay.alpha = Mathf.Lerp(0f, 1f, timer / sceneFadeDuration);
            timer += Time.deltaTime;
            yield return null;
        }

        sceneFadeOverlay.alpha = 1f;

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
