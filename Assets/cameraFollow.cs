using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;
    public float smoothspeed = 0.125f;
    public Vector3 starterPos = new Vector3(-9.1f, -4.7f, 8f);
    public float startCameraSize;
    private void Start()
    {
        startCameraSize = Camera.main.orthographicSize;
    }
    private void LateUpdate()
    {
        {
            Vector3 desirefPos = player.position + offset;
            Vector3 smootherPos = Vector3.Lerp(transform.position, desirefPos, smoothspeed);
            transform.position = smootherPos;
            if(player.transform.position.y > 1.73f )
            {
                Camera.main.orthographicSize = startCameraSize + (player.transform.position.y - 1.73f)/4;
            }
        }
    }
}
