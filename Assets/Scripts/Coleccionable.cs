using UnityEngine;

public class Coleccionable : MonoBehaviour
{
    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            Debug.Log("Algo ha tocado la moneda");
            GameManager.instance.AddCoin(); // Para que el contador de monedas aumente al tocarla el jugador
            Destroy(this.gameObject); // Para que desaparezca la moneda al tocarla el jugador
        }
    }
}
