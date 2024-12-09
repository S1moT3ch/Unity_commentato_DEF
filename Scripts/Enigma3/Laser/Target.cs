using UnityEngine;
using UnityEngine.SceneManagement;

public class Target : MonoBehaviour
{
    public void Hit() //se si colpisce il laser, si carica una nuova scena per ritentare il gioco
    {
        Debug.Log("Target Hit");
        SceneManager.LoadScene(2);
    }
}
