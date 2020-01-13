using LukasNicoTankstelle.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Model
{
    public class Checkout
    {
        public int Number { get; set; }

        public Dictionary<double,int> Cash = new Dictionary<double,int>();
        public Checkout(int number,int _5Rap, int _10Rap, int _20Rap,int _50Rap, int _1CHF, int _2CHF, int _5CHF, int _10CHF, int _20CHF, int _50CHF,int _100CHF, int _200CHF)
        {
            Cash.Add(0.05,_5Rap);
            Cash.Add(0.1, _10Rap);
            Cash.Add(0.2, _20Rap);
            Cash.Add(0.5, _50Rap);
            Cash.Add(1, _1CHF);
            Cash.Add(2, _2CHF);
            Cash.Add(5, _5CHF); 
            Cash.Add(10, _10CHF);
            Cash.Add(20, _20CHF);
            Cash.Add(50, _50CHF);
            Cash.Add(100, _100CHF);
            Cash.Add(200, _5Rap);

        }

        public Dictionary<double, int> processingPaymentCash(double amountOwed, Dictionary<double, int> cashGivenCoins, double chashGivenAmount)
        {
            //Im Dictionary repräsentiert der Double den montäre Wert und der Int die Anzahl der Währung
            //Zuerst wird das gegeben Geld einkassiert
            foreach(KeyValuePair<double, int> coinGiven in cashGivenCoins)
            {
                Cash[coinGiven.Key] += coinGiven.Value;
            }

            double totalToBeReturn = chashGivenAmount - amountOwed;
            Dictionary<double, int> changeMoney = new Dictionary<double, int>();

            //Und dann dass Rückgeld berechnet
            
            foreach (KeyValuePair<double, int> coin in Cash.OrderByDescending(x => x.Key))
            {
                if (totalToBeReturn / coin.Key > 1)
                {
                    int amountOfCoinToBeReturned = Convert.ToInt32(Math.Floor(totalToBeReturn / coin.Key));
                    changeMoney.Add(coin.Key, amountOfCoinToBeReturned);
                    totalToBeReturn -= coin.Key * amountOfCoinToBeReturned;
                    //Cash[coin.Key] -= amountOfCoinToBeReturned;
                }
            }

            //Dann wird dass Rückgeld aus der Kasse genommen
            {
                foreach(KeyValuePair <double, int> coin in changeMoney)
                {
                    Cash[coin.Key] -= coin.Value;
                }
            }
            
            return changeMoney;
        }

        public void FinishedBuying(PetrolPump usedPump)
        {
            usedPump.WasUsed = false;
            usedPump.AmountOwned = 0;

        }

    }
}
