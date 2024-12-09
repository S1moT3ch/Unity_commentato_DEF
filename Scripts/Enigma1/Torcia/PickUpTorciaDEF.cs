using UnityEngine;

public class PickUpTorciaDEF : MonoBehaviour
{
    public GameObject torcia;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        torcia.SetActive(true); //all'inizio, la torcia a terra viene visualizzata
    }

    // Update is called once per frame
    void Update()
    {
        if (Torcia.istance.clickOn) //se si clicca sulla torcia, questa non viene più visualizzata
        {
            torcia.SetActive(false);
        }
    }
}
