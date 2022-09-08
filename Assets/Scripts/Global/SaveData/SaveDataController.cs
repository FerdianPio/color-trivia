using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorTrivia.SaveData
{
    public class SaveDataController : MonoBehaviour
    {
        public int Coin;
        public string[] UnlockedPack;
        public string[] CompletedPack;
        public string[] CompletedLevel;
        SaveDataModel saveDataModel = new SaveDataModel();
        
        public void Save()
        {
            saveDataModel.Coin = Coin;
            saveDataModel.UnlockedPack = UnlockedPack;
            saveDataModel.CompletedPack = CompletedPack;
            saveDataModel.CompletedLevel = CompletedLevel;
            string json = JsonUtility.ToJson(saveDataModel);
            PlayerPrefs.SetString("SaveData", json);
        }

        public void Load()
        {
            string json = PlayerPrefs.GetString("SaveData");

            if (string.IsNullOrWhiteSpace(json))
            {
                saveDataModel = new SaveDataModel();
            }
            else
            {
                saveDataModel = JsonUtility.FromJson<SaveDataModel>(json);
            }
        }
    }

}

public class SaveDataModel
{
    public int Coin;
    public string[] UnlockedPack;
    public string[] CompletedPack;
    public string[] CompletedLevel;
}
