using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    
    public void StartPlayButton() //se viene invocata questa funzione cliccando sul relativo tasto, carica la scena 2
    {
        SceneManager.LoadScene(2);
    }
}
