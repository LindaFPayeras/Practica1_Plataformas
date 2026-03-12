using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    private int lives = 3;
    public int Lives => lives; 

    private int coins ;
    
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
        if (coins >= 3)
        {
            Debug.Log("¡Has ganado!");
            OnCoinsChanged?.Invoke(coins);
            coins = 0;

        }
        
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
            lives = 3;
        }
    }

    
}