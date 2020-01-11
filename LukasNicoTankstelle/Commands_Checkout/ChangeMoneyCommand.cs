using KinoModel.ViewModel;
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
    public class ChangeMoneyCommand : RelayCommand
    {
        private Checkout_ViewModel checkout_ViewModel;

        public ChangeMoneyCommand(Checkout_ViewModel newcheckout_ViewModel)
        {
            checkout_ViewModel = newcheckout_ViewModel;
        }

        public override void Execute(object parameter)
        {
            if (checkout_ViewModel.Cost <= checkout_ViewModel.Paid)
            {
                double changeMoney = checkout_ViewModel.Paid - checkout_ViewModel.Cost;
                string message = $"Zahlung erfolgreich beendet";
                string title = "Gratuliere";
                MessageBox.Show(message, title);

            }
            else
            {
                double amountToPay = checkout_ViewModel.Cost - checkout_ViewModel.Paid;
                string message = $"Sie haben nicht alles Bezahlt. Sie sind noch {amountToPay}CHF zu bezahlen";
                string title = "Warnung ";
                MessageBox.Show(message, title);
            }


            checkout_ViewModel.Paid = checkout_ViewModel.Cost;
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
