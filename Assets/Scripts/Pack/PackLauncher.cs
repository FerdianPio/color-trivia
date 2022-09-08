using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ColorTrivia.PackData;

namespace ColorTrivia.PackScene
{
    public class PackLauncher : MonoBehaviour
    {
        [SerializeField] private Button backButton;
        public PackDataController packDataController;
        void Start()
        {
            backButton.onClick.RemoveAllListeners();
            backButton.onClick.AddListener(GoBack);
            packDataController.LoadPackList();
        }

        public void GoBack()
        {
            SceneManager.LoadScene("Home");
        }

        public void SelectPack(string packID)
        {
            SceneManager.LoadScene("Level");
            PlayerPrefs.SetString("packID", packID);
        }
    }

}
