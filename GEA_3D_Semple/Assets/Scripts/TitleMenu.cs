using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleMenu : MonoBehaviour
{

    public string gameSceneName = "SempleScene";

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene(gameSceneName);
    }

    // Update is called once per frame
    public void QuitGame()
    {
        Application.Quit();
    }
}
