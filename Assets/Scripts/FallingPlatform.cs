using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Vector3 position0;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        position0 = transform.position;
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Invoke("gravityOn", 1.0f);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            Invoke("gravityOff", 0.5f);
        }
    }

    void gravityOn()
    {
        rb.useGravity = true;
    }

    void gravityOff()
    {
        transform.position = position0;
        rb.useGravity = false;
    }
}
