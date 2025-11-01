using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookMouse : MonoBehaviour {
    public Transform PivCamX1;//Es Hijo del Player
    public Transform PivCamY1;//Es Hijo de la PivCamX1.
    //La Camara es Hijo del PivCamY1
    public float mouseSensibility;
    private float limitedX;

    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensibility * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensibility * Time.deltaTime;

        limitedX -= mouseY;
        limitedX = Mathf.Clamp(limitedX, -45f, 45f);

        PivCamX1.Rotate(Vector3.up * mouseX);
        PivCamY1.localRotation = Quaternion.Euler(limitedX,0f,0f);

    }

}
