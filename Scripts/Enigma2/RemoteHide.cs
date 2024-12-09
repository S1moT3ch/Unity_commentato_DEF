using UnityEngine;

public class RemoteHide : MonoBehaviour
{
    public GameObject r3;
    public GameObject r7;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {  

    }

    // Update is called once per frame
    void Update() //se si clicca su uno dei pezzi a terra da passare nella stanza dove effettivamente si trova il quadro, si nasconde il pezzo a terra
    {
        if (Pr3.istance.clickOnH)
        {
            r3.SetActive(false);
            if (Pr7.istance.clickOnH)
            {
                r7.SetActive(false);
            }
        }
        else if (Pr7.istance.clickOnH)
        {
            r7.SetActive(false);
            if (Pr3.istance.clickOnH)
            {
                r3.SetActive(false);
            }
        }
    }
}
