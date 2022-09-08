using ColorTrivia.LevelScene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorTrivia.LevelData
{
    public class LevelDataView : MonoBehaviour
    {
        [SerializeField] private Text levelNameLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Image completeImage;

        public string levelID;

        private void Start()
        {
            LevelLauncher levelLauncher = GameObject.Find("LevelLauncher").gameObject.GetComponent<LevelLauncher>();
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(() => levelLauncher.SelectLevel(levelID));
        }
    }

}
