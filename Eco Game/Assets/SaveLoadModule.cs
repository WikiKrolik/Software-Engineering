using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadModule
{
    public static void SavePlayer()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        // where to save file
        string path = Application.persistentDataPath + "/player.dat";
        FileStream stream = new FileStream(path, FileMode.Create);
        GameData data = GameData.gamedata;

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void LoadPlayer()
    {

        string path = Application.persistentDataPath + "/player.dat";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            GameData.gamedata =  data;
        } else
        {
            Debug.LogError("File not found at " + path);
            
        }
    }
}
