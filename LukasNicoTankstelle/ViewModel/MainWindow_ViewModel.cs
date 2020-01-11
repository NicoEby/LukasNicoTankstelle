using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LukasNicoTankstelle.ViewModel
{
    public class MainWindow_ViewModel :ModelBase
    {
        private double liter = 1;
        private double price;
        private ICommand endPumpCommand;
        private Boolean isPumpingGuess = false;
        private double maxLiterPump = 100;

        public PetrolStation PetrolStations { get; set; } = PetrolStation.getInstance();
        public ObservableCollection<PetrolPump> PetrolPumps { get; set; }
        public Dictionary<string, PetrolPump_ViewModel> PetrolPumpVMs { get; set; }
        public Checkout_ViewModel CheckoutVM { get; set; }


        public ICommand EndPumpCommand
        {
            get { return endPumpCommand; }
            set { endPumpCommand = value; }
        }

        public double Liter
        {
            get { return liter; }
            set
            {
                
                liter = value;
                OnPropertyChanged(nameof(Liter));
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

        public Boolean IsPumpingGuess
        {
            get { return isPumpingGuess; }
            set
            {

                isPumpingGuess = value;
            }
        }

        public MainWindow_ViewModel()
        {
            PetrolPumpVMs = new Dictionary<string, PetrolPump_ViewModel>();
            PetrolPumps = new ObservableCollection<PetrolPump>();
            foreach (PetrolPump b in PetrolStations.PetrolPumps)
            {
                PetrolPumps.Add(b);
                PetrolPumpVMs.Add("PetrolPump" + b.Number, new PetrolPump_ViewModel(this, b));
            }

            CheckoutVM = new Checkout_ViewModel();

        }


        private void Do_tanken(object obj)
        {
            while (!IsPumpingGuess && Liter <= maxLiterPump)
            {
                Liter = Liter + 0.1;
                //Thread.Sleep(00);
            }
        }

        private void Do_endPump(object obj)
        {
            IsPumpingGuess = true;
        }

    }
}
