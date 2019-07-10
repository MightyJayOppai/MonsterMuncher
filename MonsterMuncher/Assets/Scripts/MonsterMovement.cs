using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterMovement : MonoBehaviour
{
    
    Rigidbody monsterRb;
    public float movementSpeed;
    public float rotationSpeed;
    void Start()
    {
        monsterRb = GetComponent<Rigidbody>();
    }

    
    void Update()
    {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");

        monsterRb.AddForce(new Vector3(moveHorizontal, 0.0f, moveVertical) * movementSpeed);
        transform.Rotate(0, Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0);
        transform.Translate(0,0, Input.GetAxis("Vertical") * Time.deltaTime * movementSpeed);
    }
}
