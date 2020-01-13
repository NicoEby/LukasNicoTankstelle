using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace LukasNicoTankstelle.ViewModel
{
    
    public class Statistic_ViewModel : ModelBase
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
                OnPropertyChanged(nameof(LastYear));
            }
        }
        public double LastMonth
        {
            get { return lastMonth; }
            set
            {
                lastMonth = value;
                OnPropertyChanged(nameof(LastMonth));
            }
        }
        public double LastWeek
        {
            get { return lastWeek; }
            set
            {
                lastWeek = value;
                OnPropertyChanged(nameof(LastWeek));
            }
        }
        public double LastDay
        {
            get { return lastDay; }
            set
            {
                lastDay = value;
                OnPropertyChanged(nameof(LastDay));
            }
        }

        public double LiterPetrol
        {
            get { return literPetrol; }
            set
            {
                literPetrol = value;
                OnPropertyChanged(nameof(LiterPetrol));
            }
        }
        public double LiterDiesel
        {
            get { return literDiesel; }
            set
            {
                literDiesel = value;
                OnPropertyChanged(nameof(LiterDiesel));
            }
        }
        public double LiterUnleaded95
        {
            get { return literUnleaded95; }
            set
            {
                literUnleaded95 = value;
                OnPropertyChanged(nameof(LiterUnleaded95));
            }
        }

        static List<Statistic_ViewModel> allStatisticsVMs = new List<Statistic_ViewModel>();

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
            allStatisticsVMs.Add(this);

        }

        public static void StatisticWasAdded(object sender, EventArgs e)
        {
            foreach(Statistic_ViewModel statisticVM in allStatisticsVMs)
            {
                statisticVM.Statistic_ = new Statistic();
                Tuple<double, double, double> literperGasolineType = statisticVM.Statistic_.TotalLiterProGasolineTypeLastDay();
                statisticVM.LastYear = statisticVM.Statistic_.TotalWinLastYear();
                statisticVM.LastMonth = statisticVM.Statistic_.TotalWinLastMonth();
                statisticVM.LastWeek = statisticVM.Statistic_.TotalWinLastWeek();
                statisticVM.LastDay = statisticVM.Statistic_.TotalWinLastDay();
                statisticVM.LiterPetrol = literperGasolineType.Item1;
                statisticVM.LiterDiesel = literperGasolineType.Item2;
                statisticVM.LiterUnleaded95 = literperGasolineType.Item3;
            }
        }
    }
}