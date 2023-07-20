using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private void OnCollisionEnter(Collision collision) {
        if (collision.collider.tag == "Obstacle") {
            Debug.Log("we got a hit");
            playerMovement.enabled = false;
        }
    }
}
