using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void OpenControllerOptions()
    {
        SceneManager.LoadScene("ControllerOptions");
    }

    public void OpenCredits()
    {
        SceneManager.LoadScene("Credits");
    }
}
