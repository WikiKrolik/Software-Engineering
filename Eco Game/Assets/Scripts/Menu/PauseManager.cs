using System.Collections;
using System.Collections.Generic;
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
        _paused = true;
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
                
            }
            else
            {
                Pause();
                
            }
        }


    }

    public void Rerun()
    {
        _paused = false;
        Time.timeScale = 1;
        _pauseMenu.SetActive(false);
    }

    public void ReturnToMenu()
    {
        SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());
        SceneManager.LoadSceneAsync("MainMenu");
    }
}

