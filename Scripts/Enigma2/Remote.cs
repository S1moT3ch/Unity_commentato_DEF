using UnityEngine;

public class Remote : MonoBehaviour
{
    public static Remote istance;

    public string pezzoricevuto;
    public GameObject r3;
    private Rigidbody rb3;
    public GameObject r7;
    private Rigidbody rb7;
    

    void Start()
    {
        rb3=r3.GetComponent<Rigidbody>(); //uso dei RigidBody per gestire la gravità sui pezzi che giungono dall'altra stanza
        rb7=r7.GetComponent<Rigidbody>();
        
        r3.SetActive(false); //all'inizio, i pezzi remoti sono nascosti e non sono soggetti a gravità
        r7.SetActive(false);
    

        rb3.useGravity = false;
        rb7.useGravity = false;
    }
    void Awake()
    {
        istance=this;
    }
    public void Update()
    {
        if (pezzoricevuto.Equals("p3")) // se il pezzo ricevuto è il numero 3 o il numero 7, viene mostrato il corrispondente pezzo remoto e viene attivata la gravità sul pezzo in questione per farlo "cadere" dalla grata
        {
            r3.SetActive(true);
            rb3.useGravity = true;
        }
        else if (pezzoricevuto.Equals("p7"))
        {
            r7.SetActive(true);
            rb7.useGravity = true;
        }
    }
}
