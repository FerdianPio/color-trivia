using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ColorTrivia.HomeScene
{
    public class HomeLauncher : MonoBehaviour
    {
        [SerializeField] private Button playButton;
        void Start()
        {
            playButton.onClick.RemoveAllListeners();
            playButton.onClick.AddListener(StartPlay);
        }

        void StartPlay()
        {
            SceneManager.LoadScene("Pack");
        }
    }

}
