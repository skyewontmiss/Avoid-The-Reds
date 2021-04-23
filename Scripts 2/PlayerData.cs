using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData : MonoBehaviour {

    public int level;

    public PlayerData (PlayerInformation player)
    {
        level = player.level;
    }
}