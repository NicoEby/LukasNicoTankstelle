using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LukasNicoTankstelle.ViewModel
{
    
    public class Stadistic_ViewModel 
    {
        public Stadistic Stadistic_ { get; set; }

        private double lastYear;
        private double lastMonth;
        private double lastWeek;
        private double lastDay;

        public double LastYear
        {
            get { return lastYear; }
            set
            {
                lastYear = value;
            }
        }
        public double LastMonth
        {
            get { return lastMonth; }
            set
            {
                lastMonth = value;
            }
        }
        public double LastWeek
        {
            get { return lastWeek; }
            set
            {
                lastWeek = value;
            }
        }
        public double LastDay
        {
            get { return lastDay; }
            set
            {
                lastDay = value;
            }
        }

        public Stadistic_ViewModel()
        {
            Stadistic_ = new Stadistic();

            LastYear = Stadistic_.TotalWinLastYear();
            LastMonth = Stadistic_.TotalWinLastMonth();
            LastWeek = Stadistic_.TotalWinLastWeek();
            LastDay = Stadistic_.TotalWinLastDay();

        }
    }
}