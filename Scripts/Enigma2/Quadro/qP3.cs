using UnityEngine;

public class qP3 : MonoBehaviour
{
    public bool clickOn = false;
    public static qP3 istance;

    void Awake()
    {
        istance=this;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown(){
        clickOn = true;
    }
}
