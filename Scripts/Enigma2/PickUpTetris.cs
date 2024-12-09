using UnityEngine;

public class PickUpTetris : MonoBehaviour
{
    public GameObject tP1;
    public GameObject tP2;
    public GameObject tP3;
    public GameObject rP3;
    public GameObject tP4;
    public GameObject tP5;
    public GameObject tP6;
    public GameObject tP7;
    public GameObject rP7;
    public GameObject tP8;
    public GameObject tP9;
    public GameObject tP10;
    public GameObject tP11;
    public GameObject tP12;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (P1.istance.clickOn) //se si clicca sul pezzo n a terra, viene nascosto tale pezzo
        {
            tP1.SetActive(false);
            Debug.Log("Pezzo 1 terra off");
        }
        else if (P2.istance.clickOn)
        {
            tP2.SetActive(false);
            Debug.Log("Pezzo 2 terra off");
        }
        else if (P3.istance.clickOn)
        {
            tP3.SetActive(false);
        }
        else if (Pr3.istance.clickOnT)
        {
            rP3.SetActive(false);
            Debug.Log("Pezzo 3 terra remoto off");
        }
        else if (P4.istance.clickOn)
        {
            tP4.SetActive(false);
        }
        else if (P5.istance.clickOn)
        {
            tP5.SetActive(false);
        }
        else if (P6.istance.clickOn)
        {
            tP6.SetActive(false);
        }
        else if (P7.istance.clickOn)
        {
            tP7.SetActive(false);
        }
        else if (Pr7.istance.clickOnT)
        {
            rP7.SetActive(false);
        }
        else if (P8.istance.clickOn)
        {
            tP8.SetActive(false);
        }
        else if (P9.istance.clickOn)
        {
            tP9.SetActive(false);
        }
        else if (P10.istance.clickOn)
        {
            tP10.SetActive(false);
        }
        else if (P11.istance.clickOn)
        {
            tP11.SetActive(false);
        }
        else if (P12.istance.clickOn)
        {
            tP12.SetActive(false);
        }
    }
}
