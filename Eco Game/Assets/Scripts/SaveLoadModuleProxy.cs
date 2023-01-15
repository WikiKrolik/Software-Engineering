using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadModuleProxy : MonoBehaviour
{
    // Start is called before the first frame update
    public void Save()
    {
        SaveLoadModule.SaveGameState();    
        }

    // Update is called once per frame
    public void Load()
    {
        SaveLoadModule.LoadGameState();
    }
}
