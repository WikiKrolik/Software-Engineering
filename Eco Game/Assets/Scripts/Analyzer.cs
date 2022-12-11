#nullable enable

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Analyzer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        //gameObject = getAnimation<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Sprite AnalyzeDirection()
    {
        Move move = GetComponent<Move>();
        Sprite arrow = Resources.Load<Sprite>("amogus"); ;
        if (move != null)
        {
            if (move.getDirection() == "up")
            {
                arrow = Resources.Load<Sprite>("uparrow");
            }
            if (move.getDirection() == "down")
            {
                arrow = Resources.Load<Sprite>("downarrow");
            }
            if (move.getDirection() == "right")
            {
                arrow = Resources.Load<Sprite>("rightarrow");
            }
            if (move.getDirection() == "left")
            {
                arrow = Resources.Load<Sprite>("leftarrow");
            }
        }
        return arrow;
    }
}
