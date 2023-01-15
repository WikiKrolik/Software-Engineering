using System;

[Serializable]
public class GameData
{
    public float[] PlayerPosition = new float[3];

    public static GameData Instance { get; set; } = new();

    public static void SetPlayerData(Player player)
    {
        var pos = player.transform.position;
        Instance.PlayerPosition = new float[] { pos.x, pos.y, pos.z };
    }

    public static void Reset()
    {
        Instance = new();
    }
}
