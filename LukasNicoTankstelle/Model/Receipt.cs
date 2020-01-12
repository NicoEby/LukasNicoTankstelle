using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Receipt
    {

        private DateTime date;
        private double amountLiter;
        private double amountPaid;
        private GasolineType typeOfGasoline;

        public DateTime Date
        {
            get { return date; }
            set
            {
                date =  value;
            }
        }
        public double AmountLiter
        {
            get { return amountLiter; }
            set
            {
                amountLiter = value;
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
        public GasolineType TypeOfGasoline
        {
            get { return typeOfGasoline; }
            set
            {
                typeOfGasoline = value;
            }
        }



        public Receipt( double amountLiter_, double amountPaid_,GasolineType gasolineType_)
        {
            Date = DateTime.Today;
            AmountLiter = amountLiter_;
            AmountPaid = amountPaid_;
            TypeOfGasoline = gasolineType_;

        }
    }
}
