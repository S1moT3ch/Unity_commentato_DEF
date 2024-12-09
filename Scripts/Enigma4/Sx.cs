using UnityEngine;

public class Sx : MonoBehaviour
{
    public GameObject CubeP;
    private Rigidbody porta;
    public float intensity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        porta=CubeP.GetComponent<Rigidbody>(); //uso del RigidBody per gestire la torsione
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() //se si clicca sul collider del blocco sinistro
    {
        if (CubeP == null) //necessario per gestire l'eventuale caso in cui la porta del caveau sia stat già aperta
            {
                Debug.Log("Caveau già aperto");
            }
            else //altrimenti viene applicata una torsione a destra alla porta del caveau e viene aggiornata la variabile 
            {
                porta.AddTorque(new Vector3(-intensity,0,0),ForceMode.Impulse);
                CaveauManager.istance.UpdateSx(1);
            }
    }
}
