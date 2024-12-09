using UnityEngine;

public class Bottone : MonoBehaviour
{
    public GameObject laser;

    private void OnMouseDown () //se si clicca sul collider del bottone
    {
        if(laser == null) //passaggio necessario per gestire il caso in cui si clicchi dopo che il laser è stato disattivato
        {
            Debug.Log("Already Win");
        }
        else
        {
        Debug.Log("Win");
        Destroy(laser); //il laser viene disattivato
        }
    }
}
