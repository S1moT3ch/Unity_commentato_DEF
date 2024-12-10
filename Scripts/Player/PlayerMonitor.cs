using UnityEngine;

public class PlayerMonitor : MonoBehaviour
{
    public float pickUpRange = 100f;
    public bool isMonitor = false;
    public static PlayerMonitor istance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        istance=this;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Debug.Log("isMonitor "+isMonitor);
        RaycastHit hit; //uso del RayCast per capire se il player sta guardando un monitor usando un tag relativo al monitor
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange) && hit.transform.gameObject.tag == "monitor")
        {
            //update variable
            isMonitor = true;
        } 
        else
            //update variable
            isMonitor = false;
    }
}
