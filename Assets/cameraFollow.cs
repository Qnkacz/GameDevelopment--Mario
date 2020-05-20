using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothspeed = 0.125f;

    private void LateUpdate()
    {
        {
            Vector3 desirefPos = player.position + offset;
            Vector3 smootherPos = Vector3.Lerp(transform.position, desirefPos, smoothspeed);
            transform.position = smootherPos;
        }
    }
}
