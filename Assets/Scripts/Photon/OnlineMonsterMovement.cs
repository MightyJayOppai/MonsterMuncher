using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class OnlineMonsterMovement : MonoBehaviour
{
    private PhotonView PV;
    private Rigidbody multiRB;
    public float movementSpeed;
    private Transform monsterRotation;
    void Awake()
    {
        multiRB  = GetComponent<Rigidbody>();
        PV = GetComponent<PhotonView>();
        monsterRotation = GetComponent<Transform>();
    }
    void Start()
    {
        
    }

    void Update()
    {
        if(PV.IsMine)
        {
            MMRotation();
        }
    }
    void FixedUpdate()
    {
        if(PV.IsMine)
        {
            print(transform.name);
            MMMovement();
        }
    }
    void MMMovement()
    {
        multiRB.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime);
    }

    void MMRotation()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            monsterRotation.rotation*= Quaternion.Euler(0f,90f,0f);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            monsterRotation.rotation *= Quaternion.Euler(0f,-90f,0f);
        }
    }

}
