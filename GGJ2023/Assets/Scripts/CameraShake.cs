using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] bool start = false;
    [SerializeField] AnimationCurve curve;
    [SerializeField] float duration = 1f;

    // Update is called once per frame
    void Update()
    {
        if(start)
        {
            start = false;
            StartCoroutine(Shaking());
        }
    }

    IEnumerator Shaking()
    {
        Vector3 startPosition = transform.position;
        float elapseTime = 0f;

        while (elapseTime < duration)
        {
            elapseTime += Time.deltaTime;
            float strength = curve.Evaluate(elapseTime / duration);
            transform.position = startPosition + Random.insideUnitSphere * strength;
            yield return null;
        }

        transform.position = startPosition;
    }
}
