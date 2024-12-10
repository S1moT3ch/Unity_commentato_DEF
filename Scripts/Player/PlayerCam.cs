using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCam : MonoBehaviour
{
    public float sensX;
    public float sensY;

    public Transform orientation;

    float xRotation;
    float yRotation;

    Rigidbody rb;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;
        
    }
    
    private void Update()
    {
        if(ChatView.istance.isShowing) //se la chat è aperta
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ; //blocca la camera
        }
        
        else //altrimenti sblocca e ruota la camera
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;

            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime *sensX;
            float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensY;

            yRotation += mouseX;
        
            xRotation -= mouseY;
            xRotation = Mathf.Clamp(xRotation, -90f, 90f);

            transform.rotation = Quaternion.Euler(xRotation, yRotation, 0);
            orientation. rotation = Quaternion.Euler(0, yRotation,0);
        }
        
    }
}
