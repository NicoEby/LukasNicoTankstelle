using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Helpers;
using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Commands_Checkout
{
    public class RefreshCommand:RelayCommand
    {
        private Checkout_ViewModel checkout_ViewModel;

        public RefreshCommand(Checkout_ViewModel newcheckout_ViewModel)
        {
            checkout_ViewModel = newcheckout_ViewModel;
        }

        public override void Execute(object parameter)
        {
            List<PetrolPump> petrols= checkout_ViewModel.PetrolPumps;
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
