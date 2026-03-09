using UnityEngine;
using TMPro;

public class IU : MonoBehaviour
{
    public TextMeshProUGUI coinText;

    void Start()
    {
        UpdateCoinText(GameManager.instance.Coins);

        GameManager.OnCoinsChanged += UpdateCoinText;
    }

    void OnDestroy() 
    /*
        Control de errores: Si se destruye el objeto que tiene este script se destruye 
        la susbscripción al evento OnCoinsChanged para evitar errores de referencia nula
    */
    
    {
        GameManager.OnCoinsChanged -= UpdateCoinText;
    }

    void UpdateCoinText(int coinAmount) 
    {
        coinText.text = "Coins: " + coinAmount;
    }
}