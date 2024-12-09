using UnityEngine;

public class UltimaMattonella : MonoBehaviour
{
    public GameObject laser;

    private void OnTriggerEnter (Collider other) //se si tocca il collider dell'ultima mattonella
    {
        if(laser == null) //necessario per gestire il caso in cui il laser sia stato già disattivato
        {
            Debug.Log("Already Win");
        }
        else //altrimenti il laser viene distrutto
        {
        Debug.Log("Win");
        Destroy(laser);
        }
    }
}
