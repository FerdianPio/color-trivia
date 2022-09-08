using ColorTrivia.Database;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace ColorTrivia.Quiz
{
    public class QuizButton : MonoBehaviour
    {
        public int id;
        public TMP_Text answer;

        private void Start()
        {
            answer.text = DatabaseController.instance.GetLevelData(PlayerPrefs.GetString("levelID")).Choice[id];
        }
    }

}
