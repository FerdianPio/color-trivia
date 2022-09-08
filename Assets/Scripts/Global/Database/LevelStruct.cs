using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorTrivia.Database
{
    [CreateAssetMenu]
    public class LevelStruct : ScriptableObject
    {
        public string LevelID;
        public string PackID;
        public string Question;
        public string Hint;
        public string[] Choice;
        public int Answer;
    }

}
