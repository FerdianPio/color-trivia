using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ColorTrivia.GameplayScene
{
    public class GameplayLauncher : MonoBehaviour
    {
        [SerializeField] private Button backButton;

        void Start()
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(QuitGame);
        }

        public void QuitGame()
        {
            SceneManager.LoadScene("Level");
        }

        public void GoToLevelScene()
        {

        }

        public void GoToPackScene()
        {

        }
    }

}
