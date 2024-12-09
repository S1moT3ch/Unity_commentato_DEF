using UnityEngine;

public class PickUpDKitPlayer : MonoBehaviour
{
    public GameObject pDNAKit;
    public GameObject tampone;
    public bool isShowing = false;
    public static PickUpDKitPlayer istance;

    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start() //all'inizio nascondi i kit
    {
        pDNAKit.SetActive(false);
        tampone.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (DKit.istance.clickOnP) //se si clicca su un determinato kit o macchia o sul gira provette, viene mostrato il relativo kit o tampone oppure nascosto il kit e il tampone e si aggiorna la variabile relativa 
        {
            pDNAKit.SetActive(true);
            DKit.istance.clickOnP = false;
        }
        else if (DKit2.istance.clickOnP)
        {
            pDNAKit.SetActive(true);
            DKit2.istance.clickOnP = false;
            Debug.Log("kit 2 player on");
        }

        if (macchia1.istance.clickOn)
        {
            tampone.SetActive(true);
        }
        else if (macchia2.istance.clickOn)
        {
            tampone.SetActive(true);
        }
        if (giraProvette.istance.clickOn)
        {
            pDNAKit.SetActive(false);
            tampone.SetActive(false);
        }
    }
}
