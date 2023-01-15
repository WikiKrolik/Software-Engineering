using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLoadModuleProxy : MonoBehaviour
{
    // Start is called before the first frame update
    public void Save()
    {
        SaveLoadModule.SavePlayer();    
        }

    // Update is called once per frame
    public void Load()
    {
        SaveLoadModule.LoadPlayer();
    }
}
