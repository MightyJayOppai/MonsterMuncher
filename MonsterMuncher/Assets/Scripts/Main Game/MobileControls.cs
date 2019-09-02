using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MobileControls : MonoBehaviour
{   
	public float movementSpeed;
    private Transform monsterRotation;
    Rigidbody monsterRb;

	private float ScreenWidth;

    void Awake()
    {
        monsterRotation = GetComponent<Transform>();
        monsterRb = GetComponent<Rigidbody>();
    }
	void Start () 
    {
		ScreenWidth = Screen.width;
	}
	
    void FixedUpdate()
    {
        //Put this in a void Function
        monsterRb.MovePosition(transform.position + transform.forward * movementSpeed * Time.deltaTime);
    }
	void Update ()
    {
        #if UNITY_EDITOR || UNITY_STANDALONE
		if (Input.GetKeyDown(KeyCode.D))
        {
            monsterRotation.rotation*= Quaternion.Euler(0f,90f,0f);
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            monsterRotation.rotation *= Quaternion.Euler(0f,-90f,0f);
        }

        #else

		int i = 0;
		//loop over every touch found
		while (i < Input.touchCount) 
        {
			if (Input.GetTouch (i).position.x > ScreenWidth / 2) 
            {
				//move right
                monsterRotation.rotation*= Quaternion.Euler(0f,90f,0f);
			}
			else if (Input.GetTouch (i).position.x < ScreenWidth / 2) 
            {
				//move left
                monsterRotation.rotation *= Quaternion.Euler(0f,-90f,0f);
			}
			++i;
		}
        #endif
	}
}
