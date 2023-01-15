using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadModule
{
    private static string SaveFilePath => Application.persistentDataPath + "/player.dat";

    public static void SaveGameState()
    {
        using FileStream stream = new(SaveFilePath, FileMode.Create);

        BinaryFormatter formatter = new();
        GameData data = GameData.Instance;

        formatter.Serialize(stream, data);
    }

    public static void LoadGameState()
    {

        if (File.Exists(SaveFilePath))
        {
            using FileStream stream = new(SaveFilePath, FileMode.Open);

            BinaryFormatter formatter = new();
            GameData data = formatter.Deserialize(stream) as GameData;

            GameData.Instance =  data;
        } else
        {
            Debug.LogError($"File not found at {SaveFilePath}");
        }
    }
}
