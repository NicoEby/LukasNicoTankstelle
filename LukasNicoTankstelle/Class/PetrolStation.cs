using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    class PetrolStation
    {
        private string place;
        private string name;
        private List<PetrolPump> petrolPumps;
        public string Place {
            get {
                return place;
                }
            set {
                place = value;
                }
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }
        public List<PetrolPump> PetrolPumps
        {
            get { return petrolPumps; }
            set
            {
                petrolPumps = value ;
            }
        }




        public PetrolStation(string place,string name,List<PetrolPump> petrolPump)
        {
            Place = place;
            Name = name;
            PetrolPumps = petrolPump;
        }
    }
}
