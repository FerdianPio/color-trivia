using ColorTrivia.Database;
using ColorTrivia.Quiz;
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
        [SerializeField] private QuizController quizController;
        //[SerializeField] private LevelStruct currentLevel;

        void Start()
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(QuitGame);
            //currentLevel = DatabaseController.instance.GetLevelData(PlayerPrefs.GetString("levelID"));
            quizController.InitQuiz(DatabaseController.instance.GetLevelData(PlayerPrefs.GetString("levelID")));
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
