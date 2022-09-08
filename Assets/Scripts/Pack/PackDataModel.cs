using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorTrivia.PackData
{
    [CreateAssetMenu]
    public class PackDataModel : ScriptableObject
    {
        public string PackID;
        public string PackName;
        public bool IsCompleted;
        public bool IsUnlocked;
        public int UnlockCost;
    }

}
