using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destruccion : MonoBehaviour
{
    public bool Destruir;
    public Rigidbody[] Hijos;

    private void Awake() {
        Hijos = new Rigidbody[transform.childCount];
        for(int i = 0; i < transform.childCount; i++) {
            Hijos[i] = transform.GetChild(i).GetComponent<Rigidbody>();
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MeshCollider collider = GetComponent<MeshCollider>();
            collider.enabled = false;
            for (int i = 0; i < transform.childCount; i++) {
                Hijos[i].useGravity = true;
                Hijos[i].isKinematic = false;
            }
            Hijos[2].AddExplosionForce(200f, Hijos[2].transform.position, 100f, 50f,ForceMode.Force);
        }
    }

}
