using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Commands_Pump;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LukasNicoTankstelle.ViewModel
{
    public class PetrolPump_ViewModel : ModelBase
    {
        public PetrolPump_ViewModel(MainWindow_ViewModel newMainViewModel, PetrolPump petrolPump)
        {
            MainWindowViewModel = newMainViewModel;
            PetrolPumpModel = petrolPump;
            Taps = petrolPump.Taps;
            PetrolPumpTankCommand = new TankCommand(newMainViewModel, this);
            FinishedPumping = new FinishedCommand(this);
            LiterGetankt = 0;
            IsPumping = false;

        }

        private bool isPumping;
        public bool IsPumping
        {
            get { return isPumping; }
            set
            {
                isPumping = value;
                OnPropertyChanged(nameof(IsPumping));
            }
        }

        private double literGetankt;
        public double LiterGetankt
        {
            get { return literGetankt; }
            set
            {
                literGetankt = Math.Round(value, 1);
                OnPropertyChanged(nameof(LiterGetankt));
            }
        }

        private double cost;
        public double Cost
        {
            get { return cost; }
            set
            {
                cost = value;
                OnPropertyChanged(nameof(Cost));
            }
        }

        private GasolineType chosenGasolineType;
        public GasolineType ChosenGasolineType
        {
            get { return chosenGasolineType; }
            set
            {
                chosenGasolineType = value;
                OnPropertyChanged(nameof(ChosenGasolineType));
            }
        }

        public MainWindow_ViewModel MainWindowViewModel { get; set; }
        public PetrolPump PetrolPumpModel { get; set; }
        public List<Tap> Taps { get; set; }
        private ICommand petrolPumpTankCommand;
        public ICommand PetrolPumpTankCommand
        {
            get { return petrolPumpTankCommand; }
            set {   petrolPumpTankCommand = value; }
        }

        private ICommand finishedPumping;
        public ICommand FinishedPumping
        {
            get { return finishedPumping; }
            set { finishedPumping = value; }
        }
    }
}
