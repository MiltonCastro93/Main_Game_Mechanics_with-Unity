using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class MoveControllerAgent : MonoBehaviour {
    public  NavMeshAgent agent;
    public Transform rotCamX;
    public float speed;
    public bool jumping;
    public GameObject TargetJump;

    private void Update() {
        if (!jumping) {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            Vector3 direccion = rotCamX.TransformDirection(new Vector3(x, 0f, y));
            agent.Move(direccion * speed * Time.deltaTime);
        } else {
            if(Vector3.Distance(transform.position, TargetJump.transform.position)<2f){
                agent.ResetPath();//reseteo para no tener el Bug del SetDestination!
                jumping = false;
                TargetJump = null;
            } else {
                agent.SetDestination(TargetJump.transform.position);
            }
        }

    }


}

//agent.pathStatus == NavMeshPathStatus.PathComplete