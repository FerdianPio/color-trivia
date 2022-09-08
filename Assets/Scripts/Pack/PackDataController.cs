using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColorTrivia.Database;

namespace ColorTrivia.PackData
{
    public class PackDataController : MonoBehaviour
    {
        [SerializeField] private Text packNameLabel;
        [SerializeField] private Text unlockCostLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Button unlockButton;
        [SerializeField] private Image completeImage;

        private Button[] packButton;
        private string[] packList;

        public void LoadPackList()
        {
            packList = DatabaseController.instance.GetPackList();
        }

        /*public PackDataModel[] GetPackDataModel()
        {

        }*/

        public void InitPackList(PackDataModel[] pack)
        {
            LoadPackList();
            packButton = new Button[pack.Length];
            foreach(string s in packList)
            {
                GameObject btn = Instantiate(selectButton.gameObject);
                //btn.GetComponent<>
            }
        }
    }

    public class PackDataModel
    {
        public string PackID;
        public string PackName;
        public bool IsCompleted;
        public bool IsUnlocked;
        public int UnlockCost;
    }

}
