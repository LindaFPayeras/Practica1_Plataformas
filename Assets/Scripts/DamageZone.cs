using UnityEngine;


public class DamageSpace : MonoBehaviour
{
    private float lastHitTime = 0.0f;
    public float hitCooldown = 1.0f;

    private void OnTriggerStay(Collider Collider)
    {
        PlayerMovement controllerScript = Collider.gameObject.GetComponent<PlayerMovement>();
        if (controllerScript != null)
        {
            if (Time.time >= lastHitTime + hitCooldown)
               {
                GameManager.instance.LoseLife(controllerScript);
                lastHitTime = Time.time;
                Debug.Log("Player se ha dado con los pinchos");
            }
        }
    }

    
}
