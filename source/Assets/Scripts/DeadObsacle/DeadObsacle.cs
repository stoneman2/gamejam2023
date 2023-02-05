using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadObsacle : MonoBehaviour
{
    private Transform playerTransform;
    private Rigidbody2D playerRB;
    private CheckPoint checkPoint;
    
    private void Start()
    {
        playerTransform = GetComponent<Transform>();
        checkPoint = GetComponent<CheckPoint>();
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("DeadTrigger"))
        {
            playerTransform.position = checkPoint.checkPointPad;
            playerRB.velocity = Vector2.zero;
        }
    }
}
