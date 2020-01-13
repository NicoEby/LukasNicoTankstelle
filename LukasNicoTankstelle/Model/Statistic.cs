using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Statistic
    {


        public List<Tuple<string, double, double, string>> Statistics { get; set; } 


        public Statistic()
        {
            string filename = "Statistiken.txt";
            // create StreamReader-object
            using (StreamReader sr = new StreamReader(new FileStream(filename,FileMode.OpenOrCreate ,FileAccess.Read),Encoding.Default))
            {
                Statistics = new List<Tuple<string, double, double, string>>();
                for (int count = 0; sr.Peek() >= 0; count++)
                {
                    //Read line per line
                    string linestring = sr.ReadLine();
                    String[] strlist = linestring.Split(';');
                    string date = strlist[0];
                    double AmountPaid = Convert.ToDouble(strlist[1]);
                    double AmountLiter = Convert.ToDouble(strlist[2]);
                    string gasolineType = strlist[3] ;
                    Tuple<string, double, double,string> newTupleStatistic = new Tuple<string, double, double,string>(date, AmountPaid, AmountLiter,gasolineType);

                    Statistics.Add(newTupleStatistic);

                }
            }
        }

        public double TotalWinLastYear()
        {
            double winLastYear = 0;
            foreach (Tuple<string, double, double,string>  s in Statistics)
            {
                if (DateTime.Parse(s.Item1) > DateTime.Today.AddYears(-1))
                {
                    winLastYear += s.Item2;
                }
            }
            return winLastYear;
        }

        public double TotalWinLastMonth()
        {
            double winLastMonth = 0;
            foreach (Tuple<string, double, double,string> s in Statistics)
            {
                if (DateTime.Parse(s.Item1) > DateTime.Today.AddMonths(-1))
                {
                    winLastMonth += s.Item2;
                }
            }
            return winLastMonth;
        }
        public double TotalWinLastWeek()
        {
            double winLastWeek = 0;
            foreach (Tuple<string, double, double,string> s in Statistics)
            {
                if (DateTime.Parse(s.Item1) > DateTime.Today.AddDays(-7))
                {
                    winLastWeek += s.Item2;
                }
            }
            return winLastWeek;
        }
        public double TotalWinLastDay()
        {
            double winLastDay = 0;
            foreach (Tuple<string, double, double,string> s in Statistics)
            {
                if (DateTime.Parse(s.Item1) > DateTime.Today.AddDays(-1))
                {
                    winLastDay += s.Item2;
                }
            }
            return winLastDay;
        }
        public Tuple<double, double, double> TotalLiterProGasolineTypeLastDay()
        {
            double totalLiterPetrol = 0;
            double totalLiterDiesel = 0;
            double totalLiterUnleaded95 = 0;
            foreach (Tuple<string, double, double, string> s in Statistics)
            {
                if (DateTime.Parse(s.Item1) > DateTime.Today.AddDays(-1))
                {
                    if (s.Item4 == "Petrol")
                    {
                        totalLiterPetrol += s.Item3;
                    }
                    if (s.Item4 == "Diesel")
                    {
                        totalLiterDiesel += s.Item3;
                    }
                    if (s.Item4 == "Unleaded95")
                    {
                        totalLiterUnleaded95 += s.Item3;
                    }
                }

            }
            Tuple<double, double, double> literperGasolineType = new Tuple<double, double, double>(totalLiterPetrol, totalLiterDiesel, totalLiterUnleaded95);

            return literperGasolineType;
        }
    }
}
