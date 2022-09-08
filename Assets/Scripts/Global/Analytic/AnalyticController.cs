using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ColorTrivia.Analytic
{
    public class AnalyticController : MonoBehaviour
    {
        public static AnalyticController instance;
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
        public void TrackFinishLevel(string levelID)
        {
            Debug.Log(levelID);
        }
        
        public void TrackUnlockPack(string packID)
        {
            Debug.Log(packID);
        }
    }

}
