using UnityEngine;

public class PickUpTorciaPlayerDEF : MonoBehaviour
{
    public GameObject pTorcia;
    public bool isShowing = false;
    public static PickUpTorciaPlayerDEF istance;

    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pTorcia.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Torcia.istance.clickOn | Input.GetKeyDown(KeyCode.F12)) //se si clicca sulla torcia a terra oppure si preme il tasto F12, viene mostrata la torcia in mano al player o viceversa
        {
            pTorcia.SetActive(!isShowing);
            isShowing = !isShowing;
            Torcia.istance.clickOn = false;
        }  
    }
}
