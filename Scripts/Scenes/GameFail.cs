using UnityEngine;
using UnityEngine.SceneManagement;

public class GameFail : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() //se si clicca col mouse sul collier, carica la scena 2
    {
        SceneManager.LoadScene(2);
    }
}
