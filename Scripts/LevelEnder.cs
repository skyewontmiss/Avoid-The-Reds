using UnityEngine;

public class LevelEnder : MonoBehaviour {

    public GameManager gameManager;

    void OnTriggerEnter ()
    {
        gameManager.CompletedLevel();
    }

}
