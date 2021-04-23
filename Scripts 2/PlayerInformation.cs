using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInformation : MonoBehaviour { 

    public int level = 1;

    public void SavePlayer ()
    {
        SaveEngine.SavePlayer(this);
    }

    public void LoadPlayer ()
    {
         PlayerData data = SaveEngine.LoadPlayer();

        level = data.level;
    }

}
