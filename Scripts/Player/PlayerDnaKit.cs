using UnityEngine;

public class PlayerDnaKit : MonoBehaviour
{
    public float pickUpRange = 100f;
    public bool isBlood1 = false;
    public bool isBlood2 = false;
    public static PlayerDnaKit istance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    void Awake()
    {
        istance=this;
    }

    // Update is called once per frame
    void FixedUpdate() //uso del RayCast per capire se il player sta guardando una determinata macchia di sangue usando dei tag relativi ad ogni macchia
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange) && hit.transform.gameObject.tag == "sangue1")
        {
            //update variable
            isBlood1 = true;
        } 
        else
            //update variable
            isBlood1 = false;
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, pickUpRange) && hit.transform.gameObject.tag == "sangue2")
        {
            //update variable
            isBlood2 = true;
        } 
        else
            //update variable
            isBlood2 = false;
    }
}
