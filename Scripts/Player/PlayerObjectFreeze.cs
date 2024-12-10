using UnityEngine;

public class PlayerObjectFreeze : MonoBehaviour
{
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (PlayerMonitor.istance.isMonitor | ChatView.istance.isShowing) //se il player sta guardando il monitor oppure la chat è aperta, blocca la posizione del player
        {
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
            GetComponent<Rigidbody>().freezeRotation = true;
        }
        else //altrimenti sblocca il player
        {
            Debug.Log("movimento");
            GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
