using UnityEngine;

public class Pr3 : MonoBehaviour
{
    public bool clickOn = false;
    public bool clickOnT = false;
    public bool clickOnH = false;
    public static Pr3 istance;

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

    void OnMouseDown() //se si clicca sul collider, si aggiornano le variabili booleane per attivare i trigger, analogo ragionamento vale per l'altro script nella stessa cartella
    {
        clickOn = true;
        clickOnT = true;
        clickOnH = true;
    }
}
