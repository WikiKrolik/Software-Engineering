using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch2 : MonoBehaviour
{
    public GameObject up;
    public GameObject on;

    public bool isOn;
    public bool isUp;


    // Start is called before the first frame update
    void Start()
    {
        on.SetActive(isOn);
        up.SetActive(isUp);

        if (!isOn)
        {
            Main.Instance.SwitchChange(1);
        }

    }

    private void OnMouseUp()
    {
        isUp = !isUp;
        isOn = !isOn;

        on.SetActive(isOn);
        up.SetActive(isUp);

        if (!isOn)
        {
            Main.Instance.SwitchChange(1);
        }
        else
        {
            Main.Instance.SwitchChange(-1);

        }
    }
}
    