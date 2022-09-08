using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColorTrivia.PackScene;

namespace ColorTrivia.PackData
{
    public class PackDataView : MonoBehaviour
    {
        [SerializeField] private Text packNameLabel;
        [SerializeField] private Text unlockCostLabel;
        [SerializeField] private Button selectButton;
        [SerializeField] private Button unlockButton;
        [SerializeField] private Image completeImage;

        PackLauncher packLauncher;

        public string packName;
        void Start()
        {
            packLauncher = GameObject.Find("PackLauncher").gameObject.GetComponent<PackLauncher>();
            selectButton.onClick.RemoveAllListeners();
            selectButton.onClick.AddListener(()=>packLauncher.SelectPack(packName));
        }


    }

}
