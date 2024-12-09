using UnityEngine;

public class Dx : MonoBehaviour
{
    public GameObject CubeP;
    private Rigidbody porta;
    public float intensity;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        porta=CubeP.GetComponent<Rigidbody>(); //uso del RigidBody per gestire la torsione della porta del Caveau
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() //cliccando sul collider del blocco per girare a destra
    {
        if (CubeP == null) //necessario per gestire il caso in cui la porta del caveau sia stata già aperta
            {
                Debug.Log("Caveau già aperto");
            }
            else //altrimenti viene applicata una torsione a destra alla porta del caveau e viene aggiornata la variabile relativa la numero di giri a destra per gestire la giusta sequenza di apertura 
            {
                porta.AddTorque(new Vector3(intensity,0,0),ForceMode.Impulse);
                CaveauManager.istance.UpdateDx(1);
            }
    }
}
