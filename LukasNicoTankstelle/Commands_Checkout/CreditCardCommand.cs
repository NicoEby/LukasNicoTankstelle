using KinoModel.ViewModel;
using LukasNicoTankstelle.ViewModel;
using LukasNicoTankstelle.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using LukasNicoTankstelle.Class;

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
            checkout_ViewModel.PetrolPumpModel = checkout_ViewModel.PetrolPumps[0];
            checkout_ViewModel.PetrolPumpModel.OpenPump(checkout_ViewModel.PetrolPumpModel);
            Receipt receipt = checkout_ViewModel.PetrolPumpModel.ReceiptOfPump;
            receipt.SaveData();
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
