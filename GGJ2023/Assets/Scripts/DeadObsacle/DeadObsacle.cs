using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadObsacle : MonoBehaviour
{
    
    private void Start()
    {
        
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeadTrigger"))
        {
            Debug.Log("You are dead");
        }
    }
}
