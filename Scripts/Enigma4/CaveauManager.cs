using UnityEngine;

public class CaveauManager : MonoBehaviour
{
    public static CaveauManager istance;
    public bool adx = false; //variabili booleane per gestire i gruppi di rotazioni a dx o a sx
    public bool bsx = false;
    public bool cdx = false;
    public bool dsx = false;

    private int aadx = 0; //variabili per gestire ogni singola rotazione 
    private int basx = 0;
    private int cadx = 0;
    private int dasx = 0;

    public GameObject porta;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    void Awake()
    {
        istance=this;
    }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (aadx == 1)
            adx = true;
        else
            adx = false;

        if (cadx == 3)
            cdx = true;
        else
            cdx = false;

        if (basx == 2)
            bsx = true;
        else
            bsx = false;

        if (dasx ==1)
            dsx = true;
        else
            dsx = false;

        if (adx && bsx && cdx && dsx) //se sono state effettuate correttamente nel giusto ordine tutte le rotazioni
        {
            if (porta == null) //passaggio necessarionper gestire il caso in cui il Caveau sia stato già aperto
            {
                Debug.Log("Caveau già aperto");
            }
            else
            {
                Destroy(porta); //altrimenti distruggi la porta del caveau
            }
        }

    }

    public void UpdateDx(int volte)
    {
        if (adx == false && bsx == false && cdx == false && dsx == false) //se si clicca la prima volta a destra
            {
            aadx = aadx + volte; //aggiorna la variabile relativa
            Debug.Log("1 click prima volta a dx");
            }
        else if (adx  && bsx && cdx == false && dsx == false) //altrimenti se si clicca la terza volta a destra
        {
            cadx = cadx + volte; //aggiorna la variabile relativa
            Debug.Log("1 click terza volta a dx");
        }
        else if (adx  && bsx && cdx && dsx == false) //se non si segue l'ordine stabilito, viene resettata tutta la procedura già fatta o
        per aprire la porta 
        {
            aadx = 0;
            adx = false;
            basx = 0;
            bsx = false;
            cadx = 0;
            cdx = false;
            Debug.Log("reset");
        }
    }

    public void UpdateSx(int volte)
    {
        if (adx && bsx == false && cdx == false && dsx == false) //se si clicca la prima volta a sx
        {
            basx = basx + volte; //aggiorna la variabile relativa
            Debug.Log("1 click seconda volta a sx");
        }
        else if (adx && bsx && cdx == false && dsx == false) //altrimenti se non si segue l'ordine stabilito, viene resettata tutta la procedura già fatta per aprire la porta
        {
            aadx = 0;
            adx = false;
            basx = 0;
            bsx = false;
            Debug.Log("reset");
        }
        else if (adx && bsx && cdx && dsx == false) //altrimenti se si clicca la quarta volta a sinistra
        {
            dasx = dasx + volte; //aggiorna la variabile relativa
            Debug.Log("1 click quarta volta a sx");
        }
    }
}
