using ColorTrivia.LevelScene;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace ColorTrivia.LevelData
{
    public class LevelDataView : MonoBehaviour
    {
        [SerializeField] private TMP_Text levelNameLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Image completeImage;

        public LevelDataModel levelDataModel;
        //public string levelID;

        private void Start()
        {
            levelNameLabel.text = levelDataModel.LevelName;
            LevelLauncher levelLauncher = GameObject.Find("LevelLauncher").gameObject.GetComponent<LevelLauncher>();
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(() => levelLauncher.SelectLevel(levelDataModel.LevelID));
        }
    }

}
