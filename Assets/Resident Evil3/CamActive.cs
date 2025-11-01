using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamActive : MonoBehaviour
{
    public Renderer rend;

    private float timePass = 0.0f;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    void OnWillRenderObject()
    {
        timePass += Time.deltaTime;

        if (timePass > 1.0f)
        {
            timePass = 0.0f;
            print(gameObject.name + " is being rendered by " + Camera.current.name + " at " + Time.time);
        }
    }

}
