using LukasNicoTankstelle.Model;
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
        private List<Checkout> checkouts;
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

        public List<Checkout> Checkouts
        {
            get { return checkouts; }
            set
            {
                checkouts = value;
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




            Checkout checkout1 =  new Checkout(1,30, 30, 30, 30, 30, 30, 30, 30, 30, 20, 15, 15);
            Checkout checkout2 = new Checkout(2,30, 30, 30, 30, 30, 30, 30, 30, 30, 20, 15, 15);
            Checkout checkout3 = new Checkout(3,30, 30, 30, 30, 30, 30, 30, 30, 30, 20, 15, 15);
            Checkouts.Add(checkout1);
            Checkouts.Add(checkout2);
            Checkouts.Add(checkout3);


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
