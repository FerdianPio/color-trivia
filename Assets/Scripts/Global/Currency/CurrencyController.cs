using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorTrivia.SaveData;

namespace ColorTrivia.Currency
{
    public class CurrencyController : MonoBehaviour
    {
        CurrencyModel currencyModel = new CurrencyModel();

        public static CurrencyController instance;
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
        void Start()
        {
            currencyModel.Coin = SaveDataController.instance.Coin;
        }

        public int GetCoin()
        {
            return currencyModel.Coin;
        }

        public void AddCoin(int amount)
        {
            currencyModel.Coin += amount;
        }

        public bool SpendCoin(int amount)
        {
            if (currencyModel.Coin >= amount)
            {
                currencyModel.Coin -= amount;
                return true;
            }
            else return false;
        }
    }

    public class CurrencyModel
    {
        public int Coin;
    }

}
