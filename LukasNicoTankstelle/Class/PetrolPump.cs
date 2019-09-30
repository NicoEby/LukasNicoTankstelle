using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    class PetrolPump
    {
        private string number;

        private List<Tap> taps;

        public string Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }
        public List<Tap> Taps
        {
            get { return taps; }
            set
            {
                taps = value;
            }
        }

        public PetrolPump(string number, List<Tap> taps)
        {
            Number = number;
            Taps = taps;
        }

    }
}
