﻿using KinoModel.ViewModel;
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
            string title = "Kreditkarte ";
            string message = "Du hast gerade " + checkout_ViewModel.Cost + " Fr. mit Kreditkarte bezahlt";
            MessageBox.Show(message, title);

            checkout_ViewModel.Paid = checkout_ViewModel.Cost ?? 0;
            checkout_ViewModel.PetrolPumpModel = checkout_ViewModel.ChosenPump;
            checkout_ViewModel.PetrolPumpModel.OpenPump(checkout_ViewModel.PetrolPumpModel);
            Receipt receipt = checkout_ViewModel.PetrolPumpModel.ReceiptOfPump;
            receipt.SaveData();
        }

        public override bool CanExecute(object parameter)
        {
            return checkout_ViewModel.ChosenPump != null
                && checkout_ViewModel.ChosenCheckout != null;
        }

        public event EventHandler CanExecuteChanged;
    }
}
