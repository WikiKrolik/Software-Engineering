using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public GameObject on;
    public bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        on.SetActive(isOn);

        if (isOn)
        {

        }
    }
    private void OnMouseUp()
    {
        isOn = !isOn;

        on.SetActive(isOn);

    }

}
