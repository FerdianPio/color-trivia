using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ColorTrivia.SaveData;

namespace ColorTrivia.Currency
{
    public class CurrencyController : MonoBehaviour
    {
        CurrencyModel currencyModel = new CurrencyModel();
        void Start()
        {
            
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
