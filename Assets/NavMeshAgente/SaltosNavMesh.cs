using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaltosNavMesh : MonoBehaviour
{
    public GameObject Tarjet1;
    public GameObject Tarjet2;
    public bool isTrigger;
    public MoveControllerAgent player;
    public float DistanceA;
    public float DistanceB;

    private void Update() {
        if (isTrigger) { //cual de los dos tengo al lado mio... sera menor que el otro
            DistanceA = Vector3.Distance(player.transform.position, Tarjet1.transform.position);
            DistanceB = Vector3.Distance(player.transform.position, Tarjet2.transform.position);
            if (Input.GetKeyUp(KeyCode.F)) {
                player.jumping = true;
                if (DistanceA > DistanceB) {
                    player.TargetJump=Tarjet1;
                } else if (DistanceA < DistanceB) {
                    player.TargetJump=Tarjet2;
                }

            }
        }
    }

    private void OnTriggerEnter(Collider other) {
        player = other.GetComponent<MoveControllerAgent>();
    }

    private void OnTriggerStay(Collider other) {
        if (other.CompareTag("Player")) {
            isTrigger = true;
        }
    }

    private void OnTriggerExit(Collider other) {
        DistanceA = 0f;
        DistanceB = 0f;
        isTrigger = false;
        player = null;
    }
}
