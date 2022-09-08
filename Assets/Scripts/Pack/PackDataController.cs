using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColorTrivia.Database;

namespace ColorTrivia.PackData
{
    public class PackDataController : MonoBehaviour
    {
        [SerializeField] private Button selectButton;
        [SerializeField] private GameObject packButtonParent;

        private Button[] buttonList;
        private string[] packList;

        public void LoadPackList()
        {
            packList = DatabaseController.instance.GetPackList();
            InitPackList();
        }

        /*public PackDataModel[] GetPackDataModel()
        {

        }*/

        public void InitPackList(/*PackDataModel[] pack*/)
        {
            buttonList = new Button[packList.Length];
            foreach (string s in packList)
            {
                GameObject btn = Instantiate(selectButton.gameObject, packButtonParent.transform.position, Quaternion.identity, packButtonParent.transform);
                btn.GetComponent<PackDataView>().packName = s;

                //change button ui property
                //btn.GetComponent<PackDataView>().
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
