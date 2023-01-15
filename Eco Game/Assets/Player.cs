using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start() 
    {
        LoadPlayer();
    }

    public void SavePlayer()
    {   
        GameData.setPlayerData(this);
        SaveLoadModule.SavePlayer();
    }

    public void LoadPlayer()
    {
        
        
        Vector3 position;
        position.x = GameData.gamedata.position[0];
        position.y = GameData.gamedata.position[1];
        position.z = GameData.gamedata.position[2];
        transform.position = position;
        Debug.Log($"Load player postion change? {position}");
    }
}
