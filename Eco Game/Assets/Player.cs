using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public void Start() 
    {
        LoadPlayer();
    }

    public void SavePlayer()
    {   

        GameData.SetPlayerData(this);
        SaveLoadModule.SaveGameState();
    }

    public void LoadPlayer()
    {
        Vector3 position;
        float[] savedPosition = GameData.Instance.PlayerPosition;
        for (int i = 0; i < 3; i++)
        {
            position[i] = savedPosition[i];
        }
        transform.position = position;
        Debug.Log($"Setting player position to {position}");
    }
}
