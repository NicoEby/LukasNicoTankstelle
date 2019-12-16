using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LukasNicoTankstelle.Commands
{
    public class TankCommand : ICommand
    {
        private MainWindow_ViewModel mainViewModel;
        private PetrolPump_ViewModel petrolPumpViewModel;

        public TankCommand(MainWindow_ViewModel newMainViewModel, PetrolPump_ViewModel newPetrolPumpViewModel)
        {
            mainViewModel = newMainViewModel;
            petrolPumpViewModel = newPetrolPumpViewModel;
        }

        public void Execute(object parameter)
        {

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
         
    }
}
