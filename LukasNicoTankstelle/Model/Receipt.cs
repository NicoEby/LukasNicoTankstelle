using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Receipt
    {
        private Tap tap;

        private DateTime date;

        public Tap Tap
        {
            get { return tap; }
            set
            {
                tap = value;
            }
        }
        public DateTime Date
        {
            get { return date; }
            set
            {
                date =  DateTime.Today;
            }
        }

        public Receipt(Tap tap)
        {
            Tap = tap;
        }
    }
}
