using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool GameHasEnded = false;

    public float RestartDelay = 1f;

    public GameObject CompleteLevelUI;

    public void CompletedLevel ()

    {
        CompleteLevelUI.SetActive(true);  
    }

    public void GameOver ()
    {
        if (GameHasEnded == false)
        {
            GameHasEnded = true;
            Invoke("Restart", RestartDelay);
        } 
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);  
    }

}
