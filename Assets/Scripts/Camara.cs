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
        transform.position = player.transform.position + new Vector3(-0.07f, 1.24f, -2.83f);
        transform.rotation = Quaternion.Euler(0.0219220743f, 0, 0);
    }
}
