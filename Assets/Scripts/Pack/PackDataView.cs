using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColorTrivia.PackScene;
using TMPro;

namespace ColorTrivia.PackData
{
    public class PackDataView : MonoBehaviour
    {
        [SerializeField] private TMP_Text packNameLabel;
        [SerializeField] private TMP_Text unlockCostLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Button unlockButton;
        [SerializeField] private Image completeImage;

        public PackDataModel packDataModel;
        void Start()
        {
            PackLauncher packLauncher = GameObject.Find("PackLauncher").gameObject.GetComponent<PackLauncher>();
            packNameLabel.text = packDataModel.PackName;
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(()=>packLauncher.SelectPack(packDataModel.PackID));
        }


    }

}
