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


        public List<Tuple<DateTime, double, double, string>> Statistics { get; set; } 


        public Statistic()
        {
            string filename = "Statistiken.txt";
            // create StreamReader-object
            using (StreamReader sr = new StreamReader(new FileStream(filename,FileMode.OpenOrCreate ,FileAccess.Read),Encoding.Default))
            {
                Statistics = new List<Tuple<DateTime, double, double, string>>();
                for (int count = 0; sr.Peek() >= 0; count++)
                {
                    //Read line per line
                    string linestring = sr.ReadLine();
                    String[] strlist = linestring.Split(',');
                    DateTime date = Convert.ToDateTime(strlist[0]);
                    double AmountPaid = Convert.ToDouble(strlist[1]);
                    double AmountLiter = Convert.ToDouble(strlist[2]);
                    string gasolineType = strlist[3] ;
                    Tuple<DateTime, double, double,string> newTupleStadistic = new Tuple<DateTime, double, double,string>(date, AmountPaid, AmountLiter,gasolineType);

                    Statistics.Add(newTupleStadistic);

                }
            }
        }

        public double TotalWinLastYear()
        {
            double winLastYear = 0;
            foreach (Tuple<DateTime, double, double,string>  s in Statistics)
            {
                if (s.Item1 > DateTime.Today.AddYears(-1))
                {
                    winLastYear += s.Item2;
                }
            }
            return winLastYear;
        }

        public double TotalWinLastMonth()
        {
            double winLastMonth = 0;
            foreach (Tuple<DateTime, double, double,string> s in Statistics)
            {
                if (s.Item1 > DateTime.Today.AddMonths(-1))
                {
                    winLastMonth += s.Item2;
                }
            }
            return winLastMonth;
        }
        public double TotalWinLastWeek()
        {
            double winLastWeek = 0;
            foreach (Tuple<DateTime, double, double,string> s in Statistics)
            {
                if (s.Item1 > DateTime.Today.AddDays(-7))
                {
                    winLastWeek += s.Item2;
                }
            }
            return winLastWeek;
        }
        public double TotalWinLastDay()
        {
            double winLastDay = 0;
            foreach (Tuple<DateTime, double, double,string> s in Statistics)
            {
                if (s.Item1 > DateTime.Today.AddDays(-1))
                {
                    winLastDay += s.Item2;
                }
            }
            return winLastDay;
        }
        //public double TotalLiterProGasolineTypeLastDay()
        //{
        //    double totalLiterPetrol = 0;
        //    double totalLiterPetrol = 0;
        //    double totalLiterPetrol = 0;
        //    foreach (Tuple<DateTime, double, double, string> s in Stadistics)
        //    {
        //        if (s.Item1 > DateTime.Today.AddDays(-1))
        //        {
        //            if (s.Item4 == "Petrol")
        //            {

        //            }
        //        }
        //    }
        //    return winLastDay;
        //}
    }
}
