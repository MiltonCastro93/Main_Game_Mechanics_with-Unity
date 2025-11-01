using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayerA : MonoBehaviour
{
    public Rigidbody rigidBody;
    public Transform rotCamX;
    public bool isUpTorre;
    public float speed;


    // Start is called before the first frame update
    void Start() {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update() {
        if (isUpTorre) {
            if(rigidBody.IsSleeping()) {
                //rigidBody.Sleep();
                print("Dormido");
            } else {
                print("Despierto");
            }

            return;
        }
        else//lo anterior se puede borrar
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            Vector3 direccion = rotCamX.TransformDirection(new Vector3(x, 0f, y));
            rigidBody.MovePosition(transform.position+direccion * speed * Time.deltaTime);

        }




    }

    public void Hitme() {
        rigidBody.WakeUp();
    }
}
