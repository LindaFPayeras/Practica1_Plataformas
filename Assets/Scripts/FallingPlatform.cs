using UnityEngine;

public class FallingPlatform : MonoBehaviour
{
    private Vector3 position0;
    private Quaternion rotation0;
    Rigidbody rb;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        position0 = transform.position;
        rotation0 = transform.rotation;
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
            Invoke("Reset", 0.5f);
        }
    }

    void gravityOn()
    {
        rb.useGravity = true;
    }

    void Reset()
    {
        transform.position = position0;
        rb.useGravity = false;
        rb.linearVelocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        transform.rotation = rotation0;
    }
}
