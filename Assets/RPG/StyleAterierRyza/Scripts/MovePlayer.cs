using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class MovePlayer : MonoBehaviour {
    public CharacterController controller;
    public Transform rotCamX;
    public float speed;
    public bool followGame;

    void Update() {
        if(followGame) {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            Vector3 direccion = rotCamX.TransformDirection(new Vector3(x, 0f, y));
            controller.Move(direccion * speed * Time.deltaTime);
        }

    }

    private void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(rotCamX.transform.position, Vector3.forward + Vector3.up);

    }

}
