using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float sensX;
    public float sensY;


    float yRotation;

    private void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = true;
    }
    
    private void Update()
    {
        if(ChatView.istance.isShowing) //se la chat è aperta, non ruotare il player
        {
            Debug.Log("chat aperta");
        }
        else //altrimenti ruota il player secondo la posizione del cursore del mouse
        {
            float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime *sensX;

            yRotation += mouseX;
        
            transform.rotation = Quaternion.Euler(0, yRotation, 0);
        }
    }
}
