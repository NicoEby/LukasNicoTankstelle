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
        private float literPerTank;
        private GasolineType gasolineType;

        public Boolean InUse
        {
            get { return inUse; }
            set
            {
                inUse = value;
            }
        }
        public float LiterPerTank
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

        public Tap(Boolean inUse, float literPerTank,GasolineType gasolineType)
        {
            InUse = inUse;
            LiterPerTank = literPerTank;
            GasolineType = gasolineType;
        }
    }
}
