using UnityEngine;

public class macchia1 : MonoBehaviour
{
    public bool clickOn = false;
    public static macchia1 istance;

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
