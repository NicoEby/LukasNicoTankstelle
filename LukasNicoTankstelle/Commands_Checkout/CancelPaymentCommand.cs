using KinoModel.ViewModel;
using LukasNicoTankstelle.ViewModel;
using LukasNicoTankstelle.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Commands_Checkout
{
    public class CancelPaymentCommand: RelayCommand
    {
        private Checkout_ViewModel checkout_ViewModel;

        public CancelPaymentCommand(Checkout_ViewModel newcheckout_ViewModel)
        {
            checkout_ViewModel = newcheckout_ViewModel;
        }

        public override void Execute(object parameter)
        {
            checkout_ViewModel.Paid = 0;
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
