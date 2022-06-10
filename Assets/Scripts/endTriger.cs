using UnityEngine;

public class endTriger : MonoBehaviour
{
    public GameManager gameManager;
    private void OnTriggerEnter(Collider other)
    {
        gameManager.completeLevel();
    }
}
