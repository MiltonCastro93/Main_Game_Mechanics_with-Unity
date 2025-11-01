using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;
using UnityEngine.UIElements;

public class GameManager : MonoBehaviour
{
    public enum Estados { Aventura, fase1, fase2 };
    public Estados estado = Estados.Aventura;

    public Transform[] aliPosPvp;
    public Transform[] enePosPvp;
    public Vector3 posOld;
    private Quaternion rotOld;

    public GameObject[] prefabsA;

    public MovePlayer movePlayer;//cuando me toque el enemigo cambio el estado y modo
    public GameObject liderPlayer;

    public GameObject peon1;
    public GameObject peon2;
    /*
    private void Update()
    {
        if(estado == Estados.Aventura)
        {
            Aventura();
            movePlayer.followGame = true;
        }
        else if(estado== Estados.fase1)
        {
            fase1Pvp();
            movePlayer.followGame = false;
        }

    }


    public void fase1Pvp() {//voy a recorrer las posiciones para acomodar todos los NPCs
        posOld = liderPlayer.transform.position;//se pisan los datos
        rotOld = liderPlayer.transform.rotation;
        liderPlayer.SetActive(false);
        int i = 0;

        if(peon1 != null && peon2 != null) {
            Destroy(peon1);
            Destroy(peon2);
        }

        if(i == 0) {
            peon1 = Instantiate(prefabsA[0], aliPosPvp[0].transform.position, Quaternion.identity);
            liderPlayer.transform.position = aliPosPvp[1].transform.position;
            liderPlayer.transform.rotation = aliPosPvp[1].transform.rotation;
            peon2 = Instantiate(prefabsA[1], aliPosPvp[2].transform.position, Quaternion.identity);
            i++;
        }
        estado = Estados.fase2;
        liderPlayer.SetActive(true);
        fase2Pvp();
    }

    public void fase2Pvp()
    {
        print("Inicio Pelea");
    }

    public void Aventura() {
        liderPlayer.SetActive(false);
        liderPlayer.SetActive(true);
        liderPlayer.transform.position = posOld;
        liderPlayer.transform.rotation = rotOld;

    }

    */
}
