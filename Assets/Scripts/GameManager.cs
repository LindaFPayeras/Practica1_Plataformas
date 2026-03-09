using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    private int lives = 3;

    int coins = 0;

    public int Coins => coins;

    public static event Action<int> OnCoinsChanged;

    void Awake()
    {
        instance = this;
    }

    public void AddCoin()
    {
        coins++;
        Debug.Log("Monedas: " + coins);

        OnCoinsChanged?.Invoke(coins);
    }

    public void LoseLife()
    {
        lives--;
        Debug.Log("Vidas: " + lives);
    }
}