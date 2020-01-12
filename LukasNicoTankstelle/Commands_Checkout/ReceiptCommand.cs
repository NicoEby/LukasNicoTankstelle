using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Helpers;
using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LukasNicoTankstelle.Commands_Checkout
{
    public class ReceiptCommand:RelayCommand
    {
        private Checkout_ViewModel checkout_ViewModel;

        public ReceiptCommand(Checkout_ViewModel newcheckout_ViewModel)
        {
            checkout_ViewModel = newcheckout_ViewModel;
        }

        public override void Execute(object parameter)
        {
            Receipt receipt=checkout_ViewModel.PetrolPumpModel.ReceiptOfPump;
            string message = $"Bezogener Treibstoffbetrag: {receipt.AmountLiter} \n Bezogener Literanzahl: {receipt.AmountLiter} \n Bezogener Treibstoffart {receipt.TypeOfGasoline} \n Datum {receipt.Date} ";
            string title = "Quittung ";
            MessageBox.Show(message, title);
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
