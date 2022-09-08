using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ColorTrivia.Database;

namespace ColorTrivia.PackData
{
    public class PackDataController : MonoBehaviour
    {
        [SerializeField] private GameObject selectButton;
        [SerializeField] private GameObject packButtonParent;

        private PackDataView[] buttonList;

        public PackDataModel[] packDataModel;

        public void LoadPackList()
        {
            InitPackList(packDataModel);
        }

        public PackDataModel[] GetPackDataModel()
        {
            return packDataModel;
        }

        public void InitPackList(PackDataModel[] pack)
        {
            foreach(PackDataModel pd in pack)
            {
                GameObject go = Instantiate(selectButton, packButtonParent.transform.position, Quaternion.identity, packButtonParent.transform);
                go.GetComponent<PackDataView>().packDataModel = pd;
            }
        }
    }
}
