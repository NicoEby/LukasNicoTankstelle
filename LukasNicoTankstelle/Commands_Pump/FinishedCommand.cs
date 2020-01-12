using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.ViewModel;
using LukasNicoTankstelle.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Commands_Pump
{
    public class FinishedCommand : RelayCommand 
    {
        private PetrolPump_ViewModel petrolPumpViewModel;

        public FinishedCommand(PetrolPump_ViewModel newPetrolPumpViewModel)
        {
            petrolPumpViewModel = newPetrolPumpViewModel;
        }

        public override void Execute(object parameter)
        {
            Tap usedTap = parameter as Tap;
            petrolPumpViewModel.PetrolPumpModel.FinishedPumping(petrolPumpViewModel.PetrolPumpModel, usedTap.GasolineType, petrolPumpViewModel.LiterGetankt, petrolPumpViewModel.Cost);
        }

        public override bool CanExecute(object parameter)
        {
            return petrolPumpViewModel.LiterGetankt > 0 && !petrolPumpViewModel.IsPumping;
        }

        public event EventHandler CanExecuteChanged;
    }
}
