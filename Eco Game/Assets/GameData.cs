using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData
{
    public float[] position;

    public static GameData gamedata;

    public static void setPlayerData(Player player)
    {
        gamedata.position = new float[3];
        gamedata.position[0] = player.transform.position.x;
        gamedata.position[1] = player.transform.position.y;
        gamedata.position[2] = player.transform.position.z;
    }
}
