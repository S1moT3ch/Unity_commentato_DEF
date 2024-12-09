using UnityEngine;
using System.Collections;

public class LightManager : MonoBehaviour
{
    public Material neonSx; //uso di due materiali emittenti diversi per ogni neon per gestire l'accensione delle luci
    public Material neonSxSpento;
    public GameObject luceSx;
    public Material neonDx;
    public Material neonDxSpento;
    public GameObject luceDx;

    private bool onSx = false;
    private bool onDx = false;
    public float lightDelay = 1f;
    private int passo = 1;
    
    public void Start()
    {
        StartCoroutine(AccendiNeon()); //avvia la routine
    }

    public void LampeggioDx() // se il neon dx è spento, accendilo, altrimenti il contrario
    {
        if(onDx)
        {
            luceDx.GetComponent<Renderer>().material = neonDxSpento;
            Debug.Log("Dx Off");
            onDx = false;

        }
        else
        {
            luceDx.GetComponent<Renderer>().material = neonDx;
            Debug.Log("Dx On");
            onDx = true;
        }
    }
    public void LampeggioSx() //se il neon sx è spento accendilo, altrimenti il contrario
    {
        if(onSx)
        {
            luceSx.GetComponent<Renderer>().material = neonSxSpento;
            Debug.Log("Sx Off");
            onSx = false;

        }
        else
        {
            luceSx.GetComponent<Renderer>().material = neonSx;
            Debug.Log("Sx On");
            onSx = true;
        }
    }
    IEnumerator AccendiNeon() // ciclo infinito
    {
         while(true) //se il passo è n, fai lampeggiare la corrispondente luce per quel passo e, quando si spegne ogni luce, passa al passo successivo
        {
            if(passo == 1)
            {
                LampeggioDx();
                if (onDx == false)
                {
                    passo = 2;
                }
            }
            else if (passo == 2)
            {
                LampeggioSx();
                if (onSx == false)
                {
                    passo = 3;
                }
            }
            else if (passo == 3)
            {
                LampeggioSx();
                if (onSx == false)
                {
                    passo = 4;
                }
            }
            else if (passo == 4)
            {
                LampeggioDx();
                if (onDx == false)
                {
                    passo = 5;
                }
            }
            else if (passo == 5)
            {
                LampeggioDx();
                if (onDx == false)
                {
                    passo = 6;
                }
            }
            else if (passo == 6)
            {
                LampeggioDx();
                if (onDx == false)
                {
                    passo = 7;
                }
            }
            else if (passo == 7)
            {
                LampeggioSx();
                if (onSx == false)
                {
                    passo = 1;
                }
            }

    
        
            yield return new WaitForSeconds(lightDelay);
        }
    }
}
