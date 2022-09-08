using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ColorTrivia.Database
{
    public class DatabaseController : MonoBehaviour
    {
        LevelStruct[] levelStruct = new LevelStruct[4];

        public static DatabaseController instance;
        private void Awake()
        {
            if (instance != null && instance != this)
            {
                Destroy(gameObject);
                return;
            }
            else
            {
                instance = this;
            }
        }
        public string[] GetPackList()
        {
            List<string> packList = new List<string>();
            foreach (LevelStruct ls in levelStruct)
            {
                foreach (string s in packList)
                {
                    if (s.Equals(ls.PackID)) break;
                }
                packList.Add(ls.PackID);
            }
            return packList.ToArray();
        }

        public string[] GetLevelList(string packID)
        {
            List<string> levelList = new List<string>();
            foreach (LevelStruct ls in levelStruct)
            {
                levelList.Add(ls.LevelID);
            }
            return levelList.ToArray();
        }

        public LevelStruct GetLevelData(string levelID)
        {
            foreach (LevelStruct ls in levelStruct)
            {
                if (ls.LevelID.Equals(levelID))
                {
                    return ls;
                }
            }
            return levelStruct[0];
        }
    }

    public struct LevelStruct
    {
        public string LevelID;
        public string PackID;
        public string Question;
        public string Hint;
        public string[] Choice;
        public int Answer;
    }
}

