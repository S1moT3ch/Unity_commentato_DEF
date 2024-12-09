using UnityEngine;

public class PickUpTetrisPlayer : MonoBehaviour
{
    public GameObject Pp1;
    public GameObject Pp2;
    public GameObject Pp3;
    public GameObject Ppr3;
    public GameObject Pp4;
    public GameObject Pp5;
    public GameObject Pp6;
    public GameObject Pp7;
    public GameObject Ppr7;
    public GameObject Pp8;
    public GameObject Pp9;
    public GameObject Pp10;
    public GameObject Pp11;
    public GameObject Pp12;
    public string pezzopassato;
    public int pezzo;
    public static PickUpTetrisPlayer istance;

    void Awake()
    {
        istance=this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Pp1.SetActive(false);
        Pp2.SetActive(false);
        Pp3.SetActive(false);
        Ppr3.SetActive(false);
        Pp4.SetActive(false);
        Pp5.SetActive(false);
        Pp6.SetActive(false);
        Pp7.SetActive(false);
        Ppr7.SetActive(false);
        Pp8.SetActive(false);
        Pp9.SetActive(false);
        Pp10.SetActive(false);
        Pp11.SetActive(false);
        Pp12.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (P1.istance.clickOn) //se si clicca sul pezzo n a terra, viene mostrato il corrispondente pezzo in mano al player
        {
            Pp1.SetActive(true);
            pezzo = 1; //viene aggiornato l'id del pezzo afferrato
            Debug.Log("Pezzo 1 player on");
            if (qP1.istance.clickOn) //se si clicca sul pezzo n nel quadro, viene nascosto il pezzo n in mano al player e vengono aggiornate le variabili per evitare alcuni bug presenti
            {
                Pp1.SetActive(false);
                Debug.Log("Pezzo 1 player off");
                P1.istance.clickOn = false;
                qP1.istance.clickOn = false;
            }
        }
        else if (P2.istance.clickOn)
        {
            Pp2.SetActive(true);
            pezzo = 2;
            Debug.Log("Pezzo 2 player on");
            if (qP2.istance.clickOn)
            {
                Pp2.SetActive(false);
                Debug.Log("Pezzo 2 player off");
                P2.istance.clickOn = false;
                qP2.istance.clickOn = false;
            }
        }
        else if (P3.istance.clickOn)
        {
            Pp3.SetActive(true);
            pezzopassato = "p3";
            
            if (Remote.istance.pezzoricevuto.Equals("p3")) //se l'id del pezzo ricevuto è uguale a 3 viene nascosto il pezzo 3 in mano al player e vengono aggiornate le variabili per evitare alcuni bug presenti
                                                           //si procede in modo analogo per il pezzo 7
            {
                Pp3.SetActive(false);
                P3.istance.clickOn = false;
            }
        }
        else if (Pr3.istance.clickOn)
        {
            Ppr3.SetActive(true);
            pezzo = 3;
            if (qP3.istance.clickOn)
            {
                Ppr3.SetActive(false);
                Pr3.istance.clickOn = false;
                Pr3.istance.clickOnT = false;
                qP3.istance.clickOn = false;
            }
        }
        else if (P4.istance.clickOn)
        {
            Pp4.SetActive(true);
            pezzo = 4;
            if (qP4.istance.clickOn)
            {
                Pp4.SetActive(false);
                P4.istance.clickOn = false;
                qP4.istance.clickOn = false;
            }
        }
        else if (P5.istance.clickOn)
        {
            Pp5.SetActive(true);
            pezzo = 5;
            if (qP5.istance.clickOn)
            {
                Pp5.SetActive(false);
                P5.istance.clickOn = false;
                qP5.istance.clickOn = false;
            }
        }
        else if (P6.istance.clickOn)
        {
            Pp6.SetActive(true);
            pezzo = 6;
            if (qP6.istance.clickOn)
            {
                Pp6.SetActive(false);
                P6.istance.clickOn = false;
                qP6.istance.clickOn = false;
            }
        }
        else if (P7.istance.clickOn)
        {
            Pp7.SetActive(true);
            pezzopassato = "p7";
            
            if (Remote.istance.pezzoricevuto.Equals("p7"))
            {
                Pp7.SetActive(false);
                P7.istance.clickOn = false;
            }
        }
        else if (Pr7.istance.clickOn)
        {
            Ppr7.SetActive(true);
            pezzo = 7;
            if (qP7.istance.clickOn)
            {
                Ppr7.SetActive(false);
                Pr7.istance.clickOn = false;
                Pr7.istance.clickOnT = false;
                qP7.istance.clickOn = false;
            }
        }
        else if (P8.istance.clickOn)
        {
            Pp8.SetActive(true);
            pezzo = 8;
            if (qP8.istance.clickOn)
            {
                Pp8.SetActive(false);
                P8.istance.clickOn = false;
                qP8.istance.clickOn = false;
            }
        }
        else if (P9.istance.clickOn)
        {
            Pp9.SetActive(true);
            pezzo = 9;
            if (qP9.istance.clickOn)
            {
                Pp9.SetActive(false);
                P9.istance.clickOn = false;
                qP9.istance.clickOn = false;
            }
        }
        else if (P10.istance.clickOn )
        {
            Pp10.SetActive(true);
            pezzo = 10;
            if (qP10.istance.clickOn)
            {
                Pp10.SetActive(false);
                P10.istance.clickOn = false;
                qP10.istance.clickOn = false;
            }
        }
        else if (P11.istance.clickOn )
        {
            Pp11.SetActive(true);
            
            if (qP11.istance.clickOn)
            {
                Pp11.SetActive(false);
                P11.istance.clickOn = false;
                qP11.istance.clickOn = false;
            }
        }
        else if (P12.istance.clickOn )
        {
            Pp12.SetActive(true);
            if (qP12.istance.clickOn)
            {
                Pp12.SetActive(false);
                P12.istance.clickOn = false;
                qP12.istance.clickOn = false;
            }
        }
    }
}
