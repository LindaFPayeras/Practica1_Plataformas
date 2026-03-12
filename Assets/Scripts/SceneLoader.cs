using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public static SceneLoader instance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MainMenu");
    } 
    public void GameOverLose()
    {
        SceneManager.LoadScene("Lose");
    }

    public void GameOverWin()
    {
        SceneManager.LoadScene("Victory");
    }
}
