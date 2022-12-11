using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadModule
{
    public static void SaveGame(Player player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        // where to save file
        string path = Application.persistentDataPath + "/player.fun"; //we can you any file type we want (.fun is just because I have to write sth)
        FileStream stream = new FileStream(path, FileMode.Create);
        GameData data = new GameData(player);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static GameData LoadGame()
    {
        string path = Application.persistentDataPath + "/player.fun";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            GameData data = formatter.Deserialize(stream) as GameData;
            stream.Close();

            return data;
        } else
        {
            Debug.LogError("File not found at " + path);
            return null;
        }
    }
}
