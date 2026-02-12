using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;
    public float rotationSpeed = 720f;
    public float jumpForce = 5f;

    public bool isGrounded;

    public int jumps = 2;

    private Rigidbody rb;
    private Vector3 direction;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Recoger las entradas del teclado
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        // Para que esté en vector unitario
        direction = new Vector3(h, 0, v).normalized;
        transform.Translate(direction * speed * Time.deltaTime, Space.World);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
                jumps = 1;
            } else if (jumps > 0)
            {
                rb.AddForce(Vector3.up*jumpForce, ForceMode.Impulse);
                jumps--;
            }
        }

        // Rotar el jugador hacia la dirección del movimiento
        if (direction != Vector3.zero)
        {
            Quaternion toRotate = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.RotateTowards(
                transform.rotation,
                toRotate,
                rotationSpeed * Time.deltaTime
            );
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        } 
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }
}
