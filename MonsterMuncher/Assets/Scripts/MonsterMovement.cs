using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    
    Rigidbody monsterRb;
    public float movementSpeed;
    public float rotationSpeed;
    private Vector3 movementInput;
    private float moveXAxis;
    private float moveYAxis;
    void Start()
    {
        monsterRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float moveXAxis = Input.GetAxis ("Horizontal");
        float moveYAxis = Input.GetAxis ("Vertical");

        movementInput = (moveXAxis * transform.right + moveYAxis * transform.forward).normalized;
        
        if(movementInput != Vector3.zero)
        {
            monsterRb.AddForce(movementInput * movementSpeed * Time.deltaTime, ForceMode.Impulse);
            transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
            transform.Translate(0,0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
        }
    }
}
