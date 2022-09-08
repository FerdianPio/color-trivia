using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace ColorTrivia.PackData
{
    public class PackDataController : MonoBehaviour
    {
        [SerializeField] private Text packNameLabel;
        [SerializeField] private Text unlockCostLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Button unlockButton;
        [SerializeField] private Image completeImage;

        public void LoadPackList()
        {

        }

        /*public PackDataModel[] GetPackDataModel()
        {

        }*/

        public void InitPackList(PackDataModel[] pack)
        {

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
