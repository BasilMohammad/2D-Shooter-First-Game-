using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
    public Transform Target;
    public float SmoothSpeed = 0.125f;
    public Vector3 offset;


	void LateUpdate ()
    {
        Vector3 desiredPosition = Target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed);
        transform.position = smoothedPosition;	
	}
}
