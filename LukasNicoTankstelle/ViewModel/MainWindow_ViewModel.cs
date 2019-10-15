using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.ViewModel
{
    public class MainWindow_ViewModel :ModelBase
    {
        private double liter = 1;
        private double price;


        public PetrolStation PetrolStations { get; set; } = PetrolStation.getInstance();
        public ObservableCollection<PetrolPump> CurrentPetrolPump { get; set; }

        public double Liter
        {
            get { return liter; }
            set
            {
                
                liter = value;
            }
        }

        public double Kosten
        {
            get { return price; }
            set
            {
                price = Liter*1.3;
                OnPropertyChanged(nameof(Kosten));
            }
        }



        public MainWindow_ViewModel()
        {
            CurrentPetrolPump = new ObservableCollection<PetrolPump>();
            foreach (PetrolPump b in PetrolStations.PetrolPumps)
            {
                CurrentPetrolPump.Add(b);
            }

        }

    }
}
