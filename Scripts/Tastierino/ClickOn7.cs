using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickOn7 : MonoBehaviour
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
        NumbersOnDisplay.istance.UpdateCodice("7");
    }
}
