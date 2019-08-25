using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;

    public float smoothSpeed = 2f;
    public Vector3 offset;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
    }

    
    void FixedUpdate()
    {
        Vector3 desiredPosition = player.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
        transform.rotation = Quaternion.Lerp(this.transform.rotation,player.rotation,.2f);
        transform.LookAt(player);    
    }
}
