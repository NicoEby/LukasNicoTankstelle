using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class PetrolStation
    {
        private string place;
        private string name;
        private List<PetrolPump> petrolPumps;
        private static PetrolStation _instance = null; //the single instance of this class

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


        //string place,string name,List<PetrolPump> petrolPump

        protected PetrolStation()
        {
            Place = "Spain";
            Name = "Salsita Petrolera" ;
            Init();
        }

        private void Init()
        {
            List<Tap> taps = new List<Tap>{
            new Tap(false, 50, GasolineType.Petrol),
            new Tap(false, 50, GasolineType.Diesel),
            new Tap(false, 50, GasolineType.Unleaded95),
        };
            PetrolPumps = new List<PetrolPump>();

            PetrolPump petrolPump1 = new PetrolPump("1",taps);
            PetrolPump petrolPump2 = new PetrolPump("1", taps);
            PetrolPump petrolPump3 = new PetrolPump("1", taps);
            PetrolPumps.Add(petrolPump1);
            PetrolPumps.Add(petrolPump2);
            PetrolPumps.Add(petrolPump3);

        }

        public static PetrolStation getInstance()
        {
            if (_instance == null)
            {
                _instance = new PetrolStation();
            }
            return _instance;
        }
    }
}
