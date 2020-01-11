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
        public int NumberOf5RapCoins { get; set; }

        public int NumberOf10RapCoins { get; set; }

        public int NumberOf20RapCoins { get; set; }
        public int NumberOf50RapCoins { get; set; }
        public int NumberOf1CHFCoins { get; set; }
        public int NumberOf2CHFCoins { get; set; }
        public int NumberOf5CHFCoins { get; set; }
        public int NumberOf10CHFCoins { get; set; }
        public int NumberOf20CHFCoins { get; set; }
        public int NumberOf50CHFCoins { get; set; }
        public int NumberOf100CHFCoins { get; set; }
        public int NumberOf200CHFCoins { get; set; }
        public Receipt Receipt { get; set; }

        public Dictionary<double,int> Cash = new Dictionary<double,int>();
        public Checkout(int number,int _5Rap, int _10Rap, int _20Rap,int _50Rap, int _1CHF, int _2CHF, int _5CHF, int _10CHF, int _20CHF, int _50CHF,int _100CHF, int _200CHF)
        {
            Number = number;
            NumberOf5RapCoins = _5Rap;
            NumberOf10RapCoins = _10Rap;
            NumberOf20RapCoins = _20Rap;
            NumberOf50RapCoins = _50Rap;
            NumberOf1CHFCoins = _1CHF;
            NumberOf2CHFCoins = _2CHF;
            NumberOf5CHFCoins = _5CHF;
            NumberOf10CHFCoins = _10CHF;
            NumberOf20CHFCoins = _20CHF;
            NumberOf50CHFCoins = _50CHF;
            NumberOf100CHFCoins = _100CHF;
            NumberOf200CHFCoins = _200CHF;

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

            //Receipt = receipt;

        }

    }
}
