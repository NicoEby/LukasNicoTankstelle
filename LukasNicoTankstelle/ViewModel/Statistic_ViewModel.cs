using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LukasNicoTankstelle.ViewModel
{
    
    public class Statistic_ViewModel 
    {
        public Statistic Statistic_ { get; set; }

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

        public Statistic_ViewModel()
        {
            Statistic_ = new Statistic();

            LastYear = Statistic_.TotalWinLastYear();
            LastMonth = Statistic_.TotalWinLastMonth();
            LastWeek = Statistic_.TotalWinLastWeek();
            LastDay = Statistic_.TotalWinLastDay();

        }
    }
}