using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform player;
    public Text ScoreDisplay;


    // Update is called once per frame
    void Update() {
    ScoreDisplay.text = player.position.z.ToString("0");  
    }
}