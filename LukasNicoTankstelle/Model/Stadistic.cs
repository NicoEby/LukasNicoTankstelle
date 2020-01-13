using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Stadistic
    {


        public Tuple<DateTime,double,double>[] Stadistics { get; set; }
        //public Stadistic(double amountPaid_, double amountLiter_)
        //{
        //    Stadistics
        //}

        public Stadistic()
        {
            string filename = "Stadistiken.txt";
            // create StreamReader-object
            using (StreamReader sr = new StreamReader(new FileStream(filename,FileMode.Open,FileAccess.Read),Encoding.Default))
            {
                for (int count = 0; sr.Peek() >= 0; count++)
                {
                    //Read line per line
                    string linestring = sr.ReadLine();
                    String[] strlist = linestring.Split(',');
                    DateTime date = Convert.ToDateTime(strlist[0]);
                    double AmountPaid = Convert.ToDouble(strlist[1]);
                    double AmountLiter = Convert.ToDouble(strlist[2]);
                    Tuple<DateTime, double, double> newTupleStadistic = new Tuple<DateTime, double, double>(date, AmountPaid, AmountLiter);

                    Stadistics[count] = newTupleStadistic;

                }
            }
        }
    }
}
