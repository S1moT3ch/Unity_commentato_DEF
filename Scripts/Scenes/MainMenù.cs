using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenù : MonoBehaviour
{
    
    public void NuovaPartita() //se viene invocata questa funzione premendo il relativo tasto nell'UI, carica la scena 1
    {
        SceneManager.LoadScene(1);
    }
}
