using UnityEngine;
using UnityEngine.SceneManagement;

public class UiController : MonoBehaviour
{
    
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Replay()
    {
        SceneManager.LoadScene(0);
    }

}
