
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public void completeLevel()
    {
        completeLevelUI.SetActive(true);
    }
    public void EngGame()
    {
        if(gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("end game");
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }        
}
