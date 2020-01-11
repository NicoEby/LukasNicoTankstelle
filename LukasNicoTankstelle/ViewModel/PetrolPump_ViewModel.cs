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
            mainWindowViewModel = newMainViewModel;
            petrolPumpModel = petrolPump;
            //new TankCommand()
            //TankenCommand = new RelayCommand(TankCommand);
        }

        private int literGetankt;
        private ICommand tankenCommand;

        public ICommand TankenCommand
        {
            get { return tankenCommand; }
            set { tankenCommand = value; }
        }

        public int LiterGetankt
        {
            get { return literGetankt; }
            set
            {
                literGetankt = value;
                OnPropertyChanged(nameof(LiterGetankt));
            }
        }

        public MainWindow_ViewModel mainWindowViewModel { get; set; }
        public PetrolPump petrolPumpModel { get; set; }
    }
}
