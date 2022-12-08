using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering.LookDev;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    [SerializeField] private string _sceneName;
    private bool _paused = false;
    [SerializeField] private GameObject _pauseMenu;
    private void Pause()
    {
        Time.timeScale = 0;
        _pauseMenu.SetActive(true);
       // Managers.GameManager.LoadScene(Managers.GameManager.Scene.Pause);
    }

    public void DeterminePause(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            if (_paused == true)
            {
                Rerun();
                _paused = false;
            }
            else
            {
                Pause();
                _paused = true;
            }
        }


    }

    public void Rerun()
    {
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
    }

    public void ReturnToMenu()
    {
        SceneManager.UnloadSceneAsync("PauseMenu");
        SceneManager.LoadSceneAsync("MainMenu");
    }
}

