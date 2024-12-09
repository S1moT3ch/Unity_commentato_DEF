using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumbersOnDisplay : MonoBehaviour
{
   
    public TextMeshProUGUI testo;
    public string codice;
    public string reset;

    public static NumbersOnDisplay istance;

    public Light luceStanza1;

    [SerializeField] private AudioClip avviso;
    private AudioSource audioSource;

    void Awake()
    {
        istance=this;
    }

    void Start()
    {
       luceStanza1.intensity = 0; //luce della stanza spenta
       audioSource = GetComponent<AudioSource>(); //si ottiene la sorgente audio
    }

    void Update()
    {
        if(codice.Equals("96691")) //se sul tastierino è scritto 96691 si accende la luce
        {
            luceStanza1.intensity = 2;
        }
    }

    public void UpdateCodice(string valore)
    {
        if(codice.Length == 5) //si cancellano i caratteri per non superare la grandezza del display
        {
            testo.text = reset;
            codice = reset + valore;
            testo.text = codice;
        }
        else //altrimenti si aggiorna il valore
        {
            codice = codice + valore;
            testo.text = codice;

            if(codice.Equals("96691")){  //se sul tastierino è scritto 96691 viene riprodotto l'audio
                audioSource.clip = avviso;
                audioSource.Play();
            }
        }
        
    }
}
