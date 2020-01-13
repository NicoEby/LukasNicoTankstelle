using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Receipt
    {

        private string date;
        private double amountLiter;
        private double amountPaid;
        private GasolineType typeOfGasoline;

        public string Date
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
            Date = DateTime.Now.ToString("dd.MM.yyy HH:mm");
            AmountLiter = amountLiter_;
            AmountPaid = amountPaid_;
            TypeOfGasoline = gasolineType_;
            StatisticWasAdded += Statistic_ViewModel.StatisticWasAdded;

        }

        public void SaveData()
        {
            string filename = "Statistiken.txt";

            using (StreamWriter sw = new StreamWriter(filename,true))
            {
                sw.WriteLine($"{Date};{AmountLiter};{AmountPaid};{TypeOfGasoline}");

            }
            OnStatisticWasAdded(EventArgs.Empty);


        }

        public event EventHandler StatisticWasAdded;

        protected virtual void OnStatisticWasAdded(EventArgs e)
        {
            EventHandler handler = StatisticWasAdded;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
