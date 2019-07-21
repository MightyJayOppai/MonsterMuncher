using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    
    Rigidbody monsterRb;
    public float movementSpeed;
    private Transform monsterRotation;
    //public float rotationSpeed;
    //private Vector3 movementInput;
    //private float moveXAxis;
    //private float moveYAxis;
    
    void Awake()
    {
        monsterRotation = GetComponent<Transform>();
        monsterRb = GetComponent<Rigidbody>();
    }
    void Start()
    {

    }

    
    void FixedUpdate()
    {
        //Put this in a void Function
        monsterRb.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime);
    }
    void Update()
    {
        //Put this in a void Function
        if (Input.GetKeyDown(KeyCode.S))
        {
            monsterRotation.rotation = Quaternion.Euler(0f,90f,0f);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            monsterRotation.rotation = Quaternion.Euler(0f,-90f,0f);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            monsterRotation.rotation = Quaternion.Euler(0f,180f,0f);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            monsterRotation.rotation = Quaternion.Euler(0f,0f,0f);
        }
        //float moveXAxis = Input.GetAxis ("Horizontal");
        //float moveYAxis = Input.GetAxis ("Vertical");

        //movementInput = (moveXAxis * transform.right + moveYAxis * transform.forward).normalized;
        
        //if(movementInput != Vector3.zero)
        //{
        //    monsterRb.AddForce(movementInput * movementSpeed * Time.deltaTime, ForceMode.Impulse);
        //    transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        //    transform.Translate(0,0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }
}
