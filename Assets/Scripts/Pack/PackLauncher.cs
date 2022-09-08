using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace ColorTrivia.PackScene
{
    public class PackLauncher : MonoBehaviour
    {
        [SerializeField] private Button backButton;
        void Start()
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(GoBack);
        }

        public void GoBack()
        {
            SceneManager.LoadScene("Home");
        }

        public void SelectPack(string packID)
        {

        }
    }

}
