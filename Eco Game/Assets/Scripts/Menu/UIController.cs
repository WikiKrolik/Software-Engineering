using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public Button _minigameButton;
    public Interactable currentTask;
    public bool taskAvailable;
    [SerializeField] public string playSceneName;

    void Start()
    {
        instance = this;
    }

    void Update()
    {
        try
        {
            taskAvailable = currentTask != null;
            _minigameButton.interactable = taskAvailable;

            if (currentTask && currentTask._isActive)
            {
                _minigameButton.GetComponentInChildren<TMP_Text>().text = "Quit Minigame";
            }
            else
            {
                _minigameButton.GetComponentInChildren<TMP_Text>().text = "Enter Minigame";
            }
        } catch (NullReferenceException)
        {
            // ignore
        }
    }

    public void OnEnterMinigameButtonPressed() {
        if (currentTask == null) {
            return;
        }

        SceneManager.LoadSceneAsync(playSceneName, LoadSceneMode.Single);
    }
}
