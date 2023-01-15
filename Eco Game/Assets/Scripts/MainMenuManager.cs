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

    public void OnLoadButonClick(int level)
    {
        SaveLoadModule.LoadGameState();
        StartGame();
    }

    private void StartGame() => SceneManager.LoadScene(_playSceneName, LoadSceneMode.Single);

    public void OnExitButtonClick()
    {
        Application.Quit();
    }
}
