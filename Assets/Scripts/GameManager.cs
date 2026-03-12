using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    private int lives = 3;

    int coins = 0;

    public int Coins => coins;

    public static event Action<int> OnCoinsChanged;
    public static event Action<int> OnLivesChanged;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }   
    }

    public void AddCoin()
    {
        coins++;
        Debug.Log("Monedas: " + coins);

        OnCoinsChanged?.Invoke(coins);
    }

    public void LoseLife(PlayerMovement player)
    {
        lives--;
        Debug.Log("Vidas: " + lives);
        OnLivesChanged?.Invoke(lives);

        if (lives > 0)
        {
            player.Respawn();
        }
        else
        {
            Debug.Log("Game Over");
            ResetGame();
        }
    }

    public void ResetGame()
    {
        coins = 0;
        lives = 3;
        Debug.Log("Juego reiniciado");
        OnCoinsChanged?.Invoke(coins);
        OnLivesChanged?.Invoke(lives);
    }
}