using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform cameraPosition; //empty GameObject per definire la posizione della camera rispetto al player

    private void Update()
    {
        if(ChatView.istance.isShowing) //se è aperta la finestra della chat
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ; //blocca la posizione della camera
        }
        else //altrimenti sblocca la posizione della camera e muovi la camera nella posizione del GameObject cameraPosition
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
            transform.position = cameraPosition.position;
        }
    }
}
