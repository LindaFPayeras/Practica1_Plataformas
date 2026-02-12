using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Vector3 posicionInicial;
    private Vector3 posicionFinal;

    [SerializeField] private float velocidad = 2.0f;
    [SerializeField] private GameObject destino;

    bool cayendo = false;

   
    private Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        posicionInicial =  transform.position;
        posicionFinal = destino.transform.position;

        destino.GetComponent<MeshRenderer>().enabled = false;

        rb = this.GetComponent<Rigidbody>();
    }

    private void FixedUpdate() 
    {
        Vector3 posActual = transform.position;

        Vector3 newPosition;
    
        newPosition = Vector3.MoveTowards(
            posActual,
            posicionFinal,
            velocidad * Time.fixedDeltaTime
        );

        if (cayendo == true)
        {
            rb.MovePosition(newPosition);
        }
        

        if (Vector3.Distance(transform.position, posicionFinal) < 0.01f)
        {
            rb.isKinematic = true;
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cayendo = true;
        } 
    }
}
