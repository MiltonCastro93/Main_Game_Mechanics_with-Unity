using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAssets : MonoBehaviour
{
    public GameObject[] pendanos;
    public MovePlayerA inUse;
    public bool subir;
    public int pos = -1;

    void Start() {
        pendanos = new GameObject[pendanos.Length];
        for(int i = 0; i < pendanos.Length; i++) {
            GameObject gameObject = transform.GetChild(i).gameObject;
            pendanos[i] = gameObject;
        }


    }

    private void Update() {
        if (inUse != null) {
            if (Input.GetKeyDown(KeyCode.E)) {
                if (!inUse.GetComponent<Rigidbody>().IsSleeping()) {
                    subir = true;
                    inUse.isUpTorre = true;
                    inUse.GetComponent<Rigidbody>().Sleep();
                    inUse.GetComponent<Rigidbody>().isKinematic = true;
                }
            }

            if (subir) {
                if (Input.GetKeyDown(KeyCode.W)) {
                    pos++;
                    subida();
                }
                if (Input.GetKeyDown(KeyCode.S)) {
                    pos--;
                    subida();
                }
            }

        }
    }

    private void OnTriggerEnter(Collider other) {
        inUse = other.GetComponent<MovePlayerA>();
        if (other.gameObject.name == "Player")
        {
            print("Player");
        }


    }

    private void OnTriggerStay(Collider other)
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("SI");
        }
        
        /*
        if(inUse != null)
        {
            print("1");
            if (Input.GetKey(KeyCode.E))
            {
                print("1-1");
                if (!inUse.GetComponent<Rigidbody>().IsSleeping())
                {
                    print("1-2");
                    subir = true;
                    inUse.isUpTorre = true;
                    inUse.GetComponent<Rigidbody>().Sleep();
                }
            }

            if (subir) {
                if (Input.GetKeyDown(KeyCode.W)) {
                    pos++;
                    subida();
                    print("2");
                }
                if (Input.GetKeyDown(KeyCode.S)) {
                    pos--;
                    subida();
                    print("3");
                }
            }

        }*/

    }

    private void OnTriggerExit(Collider other) {
        pos = -1;
    }

    private void subida()
    {
        pos = Mathf.Clamp(pos, 0, pendanos.Length - 1);
        inUse.GetComponent<MovePlayerA>().transform.position = pendanos[pos].gameObject.transform.GetChild(0).transform.position;
    }

}
