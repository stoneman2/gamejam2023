using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraControl : MonoBehaviour
{
    public CinemachineVirtualCamera cinemachineVirtualCamera;
    public Rigidbody2D rb;
    public float zoomSpeed;
    public float timeCheck = 1;

    void Start()
    {

    }


    void Update()
    {
        IdleCheck();
        ZoomInZoomOut();
    }

    private void ZoomInZoomOut()
    {
        if (rb.velocity.x != 0 && cinemachineVirtualCamera.m_Lens.OrthographicSize <= 6)
        {
            cinemachineVirtualCamera.m_Lens.OrthographicSize += Time.deltaTime * zoomSpeed;

        }
        else if (rb.velocity.x == 0 && cinemachineVirtualCamera.m_Lens.OrthographicSize >= 5 && timeCheck <= 0)
        {
            cinemachineVirtualCamera.m_Lens.OrthographicSize += Time.deltaTime * -zoomSpeed;
        }
    }

    private void IdleCheck()
    {
        if (rb.velocity.x == 0)
        {
            timeCheck -= Time.deltaTime * 1;
        }
        else if (rb.velocity.x != 0)
        {
            timeCheck = 1;
        }
    }
}

