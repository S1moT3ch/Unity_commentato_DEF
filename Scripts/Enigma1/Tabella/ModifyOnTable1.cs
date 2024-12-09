using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ModifyOnTable1 : MonoBehaviour //analoghi ragionamenti si possono fare per gli altri script seguenti
{
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;

    public static ModifyOnTable1 istance;

    void Awake()
    {
        istance=this;
    }

    public void UpdateCodiceTabella1(string valore)
    {
        if(codice.Length == 1) //se c'è già un valore, bisogna cancellarlo e poi aggiornarlo
        {
            testo.text = reset;
            codice = reset + valore;
            testo.text = codice;
        }
        else //altrimenti aggiornato il valore
        {
            codice = codice + valore;
            testo.text = codice;
        }
        
    }
}
