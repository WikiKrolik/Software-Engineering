using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.Requests;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float[] position;

    public static GameData gamedata = new GameData();

    public static void Reset()
    {
        gamedata.position = new float [] {0,0,0};
        Debug.Log("Gamedata reset");
    }

    public static void setPlayerData(Player player)
    {
        gamedata.position = new float[3];
        gamedata.position[0] = player.transform.position.x;
        gamedata.position[1] = player.transform.position.y;
        gamedata.position[2] = player.transform.position.z;
    }
}
