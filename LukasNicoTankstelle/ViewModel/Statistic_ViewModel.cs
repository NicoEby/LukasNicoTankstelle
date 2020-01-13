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
        private double literPetrol;
        private double literDiesel;
        private double literUnleaded95;

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

        public double LiterPetrol
        {
            get { return literPetrol; }
            set
            {
                literPetrol = value;
            }
        }
        public double LiterDiesel
        {
            get { return literDiesel; }
            set
            {
                literDiesel = value;
            }
        }
        public double LiterUnleaded95
        {
            get { return literUnleaded95; }
            set
            {
                literUnleaded95 = value;
            }
        }

        public Statistic_ViewModel()
        {
            Statistic_ = new Statistic();
            Tuple<double, double, double> literperGasolineType = Statistic_.TotalLiterProGasolineTypeLastDay();

            LastYear = Statistic_.TotalWinLastYear();
            LastMonth = Statistic_.TotalWinLastMonth();
            LastWeek = Statistic_.TotalWinLastWeek();
            LastDay = Statistic_.TotalWinLastDay();
            LiterPetrol = literperGasolineType.Item1;
            LiterDiesel = literperGasolineType.Item2;
            LiterUnleaded95 = literperGasolineType.Item3;

        }
    }
}