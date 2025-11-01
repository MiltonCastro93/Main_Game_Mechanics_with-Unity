using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventCameras : MonoBehaviour
{
    //el depth con mayor numero tendra la prioridad
    float depthRenderer = 10f;
    float depthInactive = 0f;

    private Camera cam;
    public MovedTank player;

    private void Start() {
        cam = transform.GetChild(0).GetComponent<Camera>();
    }

    private void Update()
    {
        if(player == null)
        {
            cam.depth = depthInactive;
        }
        else
        {
            cam.depth = depthRenderer;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = other.GetComponent<MovedTank>();
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(player != null)
        {
            cam.depth = depthRenderer;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            player = null;
        }
    }

}
