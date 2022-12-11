using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int level = 5;
    public int health = 50;

    public void SavePlayer()
    {
        SaveLoadModule.SaveGame(this);
    }

    public void LoadPlayer()
    {
        GameData data = SaveLoadModule.LoadGame();

        level = data.level;
        health = data.health;
        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;
    }
}
