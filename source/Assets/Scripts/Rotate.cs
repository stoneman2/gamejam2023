using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    private Transform transformRotate;
    [SerializeField] int speed;


    void Start()
    {
        transformRotate = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transformRotate.Rotate(new Vector3(0, 0, speed) * -Time.deltaTime);
    }
}
