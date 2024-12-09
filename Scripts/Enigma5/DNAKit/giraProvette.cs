using UnityEngine;

public class giraProvette : MonoBehaviour
{
    public bool clickOn = false;

    public static giraProvette istance;

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

    void OnMouseDown(){
        clickOn = true;  //quando si clicca sul collider, aggiorna le variabili
    }
}
