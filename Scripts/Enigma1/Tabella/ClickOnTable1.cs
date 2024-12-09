using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ClickOnTable1 : MonoBehaviour
{    
    public bool click = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha0) && click) //se si clicca il tasto 0 e si clicca sul collider, viene aggiornato nella casella 1 il valore 0, analogo ragionamento si può fare per le i successivi script, che aggiornano le altre caselle.
        {
            ModifyOnTable1.istance.UpdateCodiceTabella1("0");
            click = false;
        }
        else if(Input.GetKeyDown(KeyCode.Alpha1) && click) //se si clicca il tasto 1 e si clicca sul collider, viene aggiornato nella casella 1 il valore 1
        {
            ModifyOnTable1.istance.UpdateCodiceTabella1("1");
            click = false;
        }
    }


    void OnMouseDown(){ //se si clicca sul collider, viene aggiornata una variabile che consente l'aggiornamento dei valori
        click = true;
        Debug.Log("Click");
    }
}

