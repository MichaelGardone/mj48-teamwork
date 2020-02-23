using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public bool useSmoothedFollow = true;
    public float smoothStep = 10f;
    public Vector3 offset;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        if(useSmoothedFollow)
        {   
            Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothStep * Time.deltaTime);
            transform.position = smoothedPosition;
        }
        else
        {
            transform.position = desiredPosition;
        }
    }

}
