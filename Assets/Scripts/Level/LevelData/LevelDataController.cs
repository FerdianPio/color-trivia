using ColorTrivia.Database;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorTrivia.LevelData
{
    public class LevelDataController : MonoBehaviour
    {
        [SerializeField] private Button selectButton;
        [SerializeField] GameObject levelButtonParent;

        private string[] levelList;
        private Button[] buttonList;
        LevelDataModel[] levelDataModel = new LevelDataModel[5];

        public void LoadLevelList()
        {
            levelList = DatabaseController.instance.GetLevelList(PlayerPrefs.GetString("packID"));
            InitLevelList();
        }

        /*public LevelDataModel GetLevelList(LevelDataModel[] level)
        {
            foreach()
        }*/

        public void InitLevelList()
        {
            buttonList = new Button[levelList.Length];
            for(int i=0; i<levelList.Length; i++)
            {
                GameObject btn = Instantiate(selectButton.gameObject, levelButtonParent.transform.position, Quaternion.identity, levelButtonParent.transform);
                btn.GetComponent<LevelDataView>().levelID = levelList[i];
            }
        }
    }

}
