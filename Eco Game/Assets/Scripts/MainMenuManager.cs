using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    [SerializeField] private string _playSceneName;
    public void OnPlayButtonClick()
    {
        GameData.Reset();
        StartGame();
    }

    public void OnLoadButonClick()
    {
        SaveLoadModule.LoadGameState();
        StartGame();
    }

    private void StartGame()
    {
        Debug.Log("Starting main scene");
        SceneManager.LoadSceneAsync(_playSceneName, LoadSceneMode.Single);
    }

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
