using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovment movment;
    public GameManager gameManager;
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("colision");
        Debug.Log(collision.collider.tag);
        if(collision.collider.tag == "obstacle")
        {
            movment.enabled = false;
            FindObjectOfType<GameManager>().EngGame();
        }
    }
}

