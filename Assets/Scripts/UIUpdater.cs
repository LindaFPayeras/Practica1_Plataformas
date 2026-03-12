using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using Unity.VectorGraphics;

public class IU : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    [SerializeField] private TextMeshProUGUI livesText;

    [SerializeField] private SceneLoader sceneLoader;

    private void UpdateLives(int lives)
    {
        livesText.text = "Lives: " + lives.ToString();
        if (lives <= 0)
        {
           sceneLoader.GameOverLose();
        }
    }   

    private void UpdateCoins(int coins)
    {
        coinText.text = "Coins: " + coins.ToString() + "/3";
        if (coins >= 3)
        {
            sceneLoader.GameOverWin();
            
        }
    }  

    void Start()
    {
        UpdateCoins(GameManager.instance.Coins);
        GameManager.OnCoinsChanged += UpdateCoins;
        UpdateLives(GameManager.instance.Lives);
        GameManager.OnLivesChanged += UpdateLives;
    }

    void OnDestroy()     
    {
        GameManager.OnCoinsChanged -= UpdateCoins;
        GameManager.OnLivesChanged -= UpdateLives;
    }

   
}