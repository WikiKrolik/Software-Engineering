using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string _playSceneName;
    public void OnPlayButtonClick()
    {
        SceneManager.LoadSceneAsync(_playSceneName, LoadSceneMode.Single);
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
