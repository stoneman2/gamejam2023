using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartScene : MonoBehaviour
{
    private Transform playerTransform;
    [SerializeField] Transform enemyboss;
    private Rigidbody2D playerRB;
    private EndCheckpoint checkPoint;

    private void Start()
    {
        playerTransform = GetComponent<Transform>();
        checkPoint = GetComponent<EndCheckpoint>();
        playerRB = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Boss"))
        {
            playerTransform.position = checkPoint.endCheckPointPad;
            playerRB.velocity = Vector2.zero;
            enemyboss.position = checkPoint.enemyBoss;
        }
    }
}
