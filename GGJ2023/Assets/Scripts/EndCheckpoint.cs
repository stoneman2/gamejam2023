using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndCheckpoint : MonoBehaviour
{
    [SerializeField] AudioSource audioSource;
    [SerializeField] AudioClip audioClip;
    [SerializeField] public Vector3 endCheckPointPad;
    [SerializeField] public Vector3 enemyBoss;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("CheckPoint"))
        {
            audioSource.PlayOneShot(audioClip);
            endCheckPointPad = collision.transform.position;
            enemyBoss = new Vector3(endCheckPointPad.x - 12.5f, endCheckPointPad.y, endCheckPointPad.z);
        }
    }
}
