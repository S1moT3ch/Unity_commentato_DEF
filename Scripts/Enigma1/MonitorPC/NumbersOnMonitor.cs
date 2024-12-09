using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumbersOnMonitor : MonoBehaviour //nella cartella si trova un analogo script per un altro monitor analogo a questo
{
   
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;
    public string valoreb;

    public static NumbersOnMonitor istance;

    void Awake()
    {
        istance=this; //creazione istanza per condividere le variabili e i metodi di questa classe in altri script
    }


    public void UpdateCodice(string valore)
    {
        if (PlayerMonitor.istance.isMonitor == true) //se il player sta guardando il monitor
        {
            if (codice.Length == 23) //se lo schermo contiene troppi caratteri, cancella ciò che c'è scritto
            {
                testo.text = reset;
                codice = reset + valore;
                valoreb = valore;
                testo.text = codice;
            }
            else
            {
                codice = codice + valore;
                valoreb = valore;
                testo.text = codice;
            }
        }
    }
    public void CancellaCarattere() //metodo per cancellare il carattere sul monitor
    {
        if (PlayerMonitor.istance.isMonitor == true)
        {
            if (codice.Length <= 0)
            {
                Debug.Log("Fine Striga");
            }
            else
            {
                codice = codice.Remove(codice.Length-1);
                testo.text = codice;
            }
        }
    }
}
