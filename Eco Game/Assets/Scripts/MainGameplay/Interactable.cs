using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    [SerializeField] private GameObject _taskWindow;
    public bool _isActive = false;

    void Start() {
        _taskWindow.SetActive(false);
    }

    public void Use(bool isActive) {
        _taskWindow.SetActive(isActive);
        _isActive = isActive;
    }
}
