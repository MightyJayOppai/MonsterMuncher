using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectEnergy : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "Player")
        {
            ScoreSystem.score += 10;
            Destroy(gameObject);
        }
    }
}
