using UnityEngine;

public class qP1 : MonoBehaviour
{
    public bool clickOn = false;
    public bool clickOnQ = false;
    public static qP1 istance;

    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){ //se si clicca sul collider, si aggiornano le variabili booleane per attivare i trigger, analogo ragionamento vale per gli altri script nella stessa cartella
        clickOn = true;
        clickOnQ = true;
        Debug.Log("Pezzo 1 quadro click");
    }
}
