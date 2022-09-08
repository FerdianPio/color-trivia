using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace ColorTrivia.Database
{
    public class DatabaseController : MonoBehaviour
    {
        [SerializeField] private LevelStruct[] levelStruct = new LevelStruct[4];

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
        void OnEnable()
        {
            DontDestroyOnLoad(gameObject);
        }

        private void Start()
        {
            string[] test = GetPackList();
        }

        public string[] GetPackList()
        {
            List<string> packList = new List<string>();
            foreach (LevelStruct ls in levelStruct)
            {
                packList.Add(ls.PackID);
            }
            return packList.Distinct<string>().ToArray<string>();
        }

        public string[] GetLevelList(string packID)
        {
            List<string> levelList = new List<string>();
            foreach (LevelStruct ls in levelStruct)
            {
                if(ls.PackID.Equals(packID))
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
            return null;
        }
    }

}

