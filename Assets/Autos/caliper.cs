using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class caliper : MonoBehaviour
{
    public GameObject calipe;


    // Update is called once per frame
    void Update() {
        calipe.transform.rotation = Quaternion.Euler(0f, transform.rotation.y, 0f);

    }
}
