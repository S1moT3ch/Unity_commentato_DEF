using UnityEngine;

public class P5 : MonoBehaviour
{
    public bool clickOn = false;
    public static P5 istance;

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
