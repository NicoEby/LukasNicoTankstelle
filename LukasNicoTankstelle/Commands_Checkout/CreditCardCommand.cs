using KinoModel.ViewModel;
using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LukasNicoTankstelle.Commands
{
    public class CreditCardCommand: RelayCommand
    {
        private Checkout_ViewModel checkout_ViewModel;

        public CreditCardCommand(Checkout_ViewModel newcheckout_ViewModel)
        {
            checkout_ViewModel = newcheckout_ViewModel;
        }

        public override void Execute(object parameter)
        {
            string message = "Zahlung gemacht";
            string title = "Kreditkarte ";
            MessageBox.Show(message, title);
            checkout_ViewModel.Paid = checkout_ViewModel.Cost;
            checkout_ViewModel.PetrolPumpModel.OpenPump(checkout_ViewModel.PetrolPumpModel);
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
