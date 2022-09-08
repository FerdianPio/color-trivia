using ColorTrivia.Database;
using ColorTrivia.SaveData;
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
        LevelDataModel[] levelDataModel;

        public void LoadLevelList()
        {
            levelList = DatabaseController.instance.GetLevelList(PlayerPrefs.GetString("packID"));
            levelDataModel = new LevelDataModel[levelList.Length];
            levelDataModel = GetLevelList();
            InitLevelList();
        }

        public LevelDataModel[] GetLevelList()
        {
            List<LevelDataModel> list = new List<LevelDataModel>();
            for(int i = 0; i < levelList.Length; i++)
            {
                LevelDataModel ld = new LevelDataModel();
                ld.LevelID = levelList[i];
                ld.LevelName = levelList[i];
                foreach(string str in SaveDataController.instance.CompletedLevel)
                {
                    if (str.Equals(ld.LevelID)) ld.IsComplete = true;
                    else ld.IsComplete = false;
                }
                list.Add(ld);
                
            }
            
            return list.ToArray();
        }

        public void InitLevelList()
        {
            for(int i=0; i<levelList.Length; i++)
            {
                GameObject btn = Instantiate(selectButton.gameObject, levelButtonParent.transform.position, Quaternion.identity, levelButtonParent.transform);
                btn.GetComponent<LevelDataView>().levelDataModel = levelDataModel[i];
            }
        }
    }

}
