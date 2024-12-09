using UnityEngine;

public class Torcia : MonoBehaviour
{
    public bool clickOn = false;
    public static Torcia istance;

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
        clickOn = true; //se si clicca sul collider, viene aggiornata la variabile per attivare il trigger per afferrare la torcia in mano
    }
}
