using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip audioClip;
    [SerializeField]public Vector3 checkPointPad;

    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("CheckPoint"))
        {
            audioSource.PlayOneShot(audioClip);
            checkPointPad = collision.transform.position;
        }
    }
        


}
