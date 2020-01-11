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
        private double amountOwed;
        private double amountPaid;


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
                date =  value;
            }
        }
        public double AmountOwed
        {
            get { return amountOwed; }
            set
            {
                amountOwed = value;
            }
        }
        public double AmountPaid
        {
            get { return amountPaid; }
            set
            {
                amountPaid = value;
            }
        }


        public Receipt(Tap tap, double amountOwed_, double amountPaid_)
        {
            Tap = tap;
            Date = DateTime.Today;
            AmountOwed = amountOwed_;
            AmountPaid = amountPaid_;

        }
    }
}
