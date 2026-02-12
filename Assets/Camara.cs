using UnityEngine;

public class Camara : MonoBehaviour
{

    private Rigidbody rb;
    private Vector3 direction;

    public GameObject player;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position + new Vector3(0, 3, -5);
        transform.rotation = Quaternion.Euler(15, 0, 0);
    }
}
