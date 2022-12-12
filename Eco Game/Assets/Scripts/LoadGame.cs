using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Assets.Scripts
{
    public class LoadGame : MonoBehaviour
    {
        public string sceneName;
        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.M))
            {
                SceneManager.LoadScene(sceneName,LoadSceneMode.Additive);
            }
        }
    }
}