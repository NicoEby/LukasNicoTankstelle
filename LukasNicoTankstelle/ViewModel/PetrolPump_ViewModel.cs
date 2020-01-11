using KinoModel.ViewModel;
using LukasNicoTankstelle.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LukasNicoTankstelle.ViewModel
{
    public class PetrolPump_ViewModel: ModelBase
    {
        public PetrolPump_ViewModel(MainWindow_ViewModel newMainViewModel)
        {
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
    }
}
