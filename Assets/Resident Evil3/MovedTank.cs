using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovedTank : MonoBehaviour
{
    public float speedZ = 10f;
    public float turnSpeed = 1f;
    public CharacterController cC;
    public Animator anim;
    public Camera cam;

    void Update() {
        float turnY = Input.GetAxis("Horizontal") * turnSpeed;
        float walking = Input.GetAxis("Vertical") * speedZ;
        
        transform.Rotate(Vector3.up * turnY * Time.deltaTime);

        cC.Move(transform.forward * walking * Time.deltaTime);

        if(walking > 0) {
            anim.SetBool("isWalking", true);
            anim.SetBool("isWalkBack", false);
        }else if(walking < 0) {
            anim.SetBool("isWalking", false);
            anim.SetBool("isWalkBack", true);
        } else {
            anim.SetBool("isWalking", false);
            anim.SetBool("isWalkBack", false);
        }

        if(turnY > 0 && walking == 0) {
            anim.SetBool("TurnRight",true);
        }
        if (turnY < 0 && walking == 0) {
            anim.SetBool("TurnLeft",true);
        }
        if(turnY == 0) {
            anim.SetBool("TurnRight", false);
            anim.SetBool("TurnLeft", false);
        }


    }

}

//TurnLeft
//TurnRight