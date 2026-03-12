using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class IU : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI coinText;

    [SerializeField] private TextMeshProUGUI livesText;

    private void UpdateLives(int lives)
    {
        livesText.text = "Lives: " + lives.ToString();
    }   

    private void UpdateCoins(int coins)
    {
        coinText.text = "Coins: " + coins.ToString() + "/3";
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