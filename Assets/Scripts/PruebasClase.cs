using UnityEngine;

public class PruebasClase : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OllisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Collision Player");
        }


    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
