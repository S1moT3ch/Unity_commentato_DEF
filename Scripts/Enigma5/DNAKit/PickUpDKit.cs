using UnityEngine;

public class PickUpDKit : MonoBehaviour
{
    public GameObject DNAkit;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DNAkit.SetActive(true); //all'inizio, il kit del player è nascosto
    }

    // Update is called once per frame
    void Update()
    {
        if (DKit.istance.clickOn) //se si clicca sul collider del kit 1, mostra il kit 1 e aggiorna le varibili
        {
            DNAkit.SetActive(false);
            DKit.istance.clickOn = false;
        }
        else if (DKit2.istance.clickOn) //altrimenti se si clicca sul collider del kit2, mostra il kit 2 e aggiorna le variabili
        {
            DNAkit.SetActive(false);
            DKit.istance.clickOn = false;
        }
    }
}
