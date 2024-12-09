 using UnityEngine;

public class OnOffTorcia : MonoBehaviour

{
    public Light torcia;
    public int on;
    public static OnOffTorcia istance;
    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        torcia.intensity = 0; //all'inizio, torcia spenta
        on = 0;
    }

    // Update is called once per frame
    void Update()
    {
         if (Input.GetKeyDown(KeyCode.Mouse1)){ //se si clicca il tasto dx del mouse, si accende la torcia con colori differenti per ogni click
            AccendiTorcia();
         }
    }

    void AccendiTorcia() //uso di una variabile per capire lo stato di accensione della luce e aggiornarne il colore di conseguenza 
    {
        if (on == 0)
        {
            torcia.intensity = 8;
            torcia.color = Color.white;
            on = 1;
        }
        else if (on == 1)
        {
            torcia.intensity = 8;
            torcia.color = Color.magenta;
            on = 2;
        }
        else if (on == 2)
        {
            torcia.intensity = 0;
            on = 0;
        }
    }
}
