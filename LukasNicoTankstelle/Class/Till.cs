using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Till
    {
        private int number;

        private Boolean isFree;

        public int Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }

        public Boolean IsFree
        {
            get { return isFree; }
            set
            {
                isFree = value;
            }
        }


        public Till(int number, Boolean isfree)
        {
            Number = number;
            IsFree = isfree;
        }



    }
}
