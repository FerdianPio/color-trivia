using ColorTrivia.LevelData;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ColorTrivia.LevelScene
{
    public class LevelLauncher : MonoBehaviour
    {
        [SerializeField] private Button backButton;

        public LevelDataController levelDataController;

        void Start()
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(GoBack);
            levelDataController.LoadLevelList();
        }

        public void GoBack()
        {
            SceneManager.LoadScene("Pack");
        }

        public void SelectLevel(string levelID)
        {
            SceneManager.LoadScene("Gameplay");
            PlayerPrefs.SetString("levelID", levelID);
        }
    }

}
