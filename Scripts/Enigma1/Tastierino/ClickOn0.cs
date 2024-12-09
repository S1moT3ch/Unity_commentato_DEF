using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickOn0 : MonoBehaviour
{    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnMouseDown(){
        NumbersOnDisplay.istance.UpdateCodice("0"); //se si clicca sul collider, si aggiorna il codice, analogamente per gli altri script successivi
    }
}
