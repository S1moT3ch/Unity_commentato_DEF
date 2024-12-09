using UnityEngine;

public class ColliderMatt : MonoBehaviour
{
    public GameObject laser;
    public float passo = 3;

    private void OnTriggerEnter (Collider other) //se si entra in contatto con una mattonella
    {
        if(laser == null) //passaggio necessario per gestire l'eventuale assenza del laser, qualora questo fosse stato già distrutto
        {
            Debug.Log("Already Win");
        }
        else
        {
        Debug.Log("Hit with Collider")
        laser.transform.position = laser.transform.position + new Vector3(0, 0, passo); //il laser avanza in avanti
        }
    }
}
