using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Commands;
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

        }

        private int literGetankt;
        public int LiterGetankt
        {
            get { return literGetankt; }
            set
            {
                literGetankt = value;
                OnPropertyChanged(nameof(LiterGetankt));
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
    }
}
