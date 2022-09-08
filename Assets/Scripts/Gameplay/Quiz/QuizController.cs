using ColorTrivia.Database;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorTrivia.Quiz
{
    public class QuizController : MonoBehaviour
    {
        [SerializeField] private TMP_Text questionText;
        [SerializeField] private Image hintImage;
        [SerializeField] private Button[] answerButton;

        
        
        public void InitQuiz(LevelStruct level)
        {
            questionText.text = level.Question;
            //hintImage = 
            for(int i = 0; i < answerButton.Length; i++)
            {
                answerButton[i].gameObject.GetComponent<QuizButton>().id = i;
            }
        }

    }

}
