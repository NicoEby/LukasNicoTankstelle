using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Tap
    {
        private Boolean inUse;
        private double literPerTank;
        private GasolineType gasolineType;
        private double pricePerLiter;

        public Boolean InUse
        {
            get { return inUse; }
            set
            {
                inUse = value;
            }
        }
        public double LiterPerTank
        {
            get { return literPerTank; }
            set
            {
                literPerTank = value;
            }
        }
        public GasolineType GasolineType
        {
            get { return gasolineType; }
            set
            {
                gasolineType = value;
            }
        }

        public double PricePerLiter
        {
            get { return pricePerLiter; }
            set { pricePerLiter = value; }
        }

        public Tap(Boolean inUse, double literPerTank,GasolineType gasolineType, double newPrice)
        {
            InUse = inUse;
            LiterPerTank = literPerTank;
            GasolineType = gasolineType;
            PricePerLiter = newPrice;
        }
    }
}
