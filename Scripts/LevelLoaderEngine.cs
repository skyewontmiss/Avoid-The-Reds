using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderEngine : MonoBehaviour {

    public void LoadNextLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
