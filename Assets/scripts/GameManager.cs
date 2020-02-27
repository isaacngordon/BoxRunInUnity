
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    bool isOver = false;
    public float restartDelay = 1f;
    public GameObject levelCompleteUI;

    public void EndGame(bool hardReset)
    {
        if (!isOver)
        {
            isOver = true;
            Debug.Log("Game Oveer FOOOOL");
            if(hardReset)
                Invoke("Restart", 0);
            else
                Invoke("Restart", restartDelay);

        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        isOver = false;
    }

    public void CompleteLevel()
    {
        Debug.Log("winner chicken dinner");
        isOver = true;
        levelCompleteUI.SetActive(true);
        Invoke("Restart", 3f);
    }
}
    
