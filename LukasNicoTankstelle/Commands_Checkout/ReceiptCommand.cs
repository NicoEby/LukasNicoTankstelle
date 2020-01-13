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
            string message = $"Bezogener Treibstoffbetrag: {receipt.AmountPaid}CHF \n Bezogener Literanzahl: {receipt.AmountLiter}L \n Bezogener Treibstoffart {receipt.TypeOfGasoline} \n Datum {receipt.Date} ";
            string title = "Quittung ";
            MessageBox.Show(message, title);
            checkout_ViewModel.PetrolPumpModel.ReceiptOfPump = null;
        }

        public override bool CanExecute(object parameter)
        {
            return checkout_ViewModel.PetrolPumpModel != null
                && checkout_ViewModel.PetrolPumpModel.ReceiptOfPump != null;
        }

        public event EventHandler CanExecuteChanged;
    }
}
