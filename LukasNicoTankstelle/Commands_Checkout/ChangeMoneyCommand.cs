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
            //Diese Methode gibt das Wechselgeld zurück beruhend auf dem Preis und dem gegebenen Betrag
            Dictionary<double, int> changeMoney =
            checkout_ViewModel.ChosenCheckout.processingPaymentCash(
                checkout_ViewModel.Cost ?? 0,
                new Dictionary<double, int>()
                {
                    {200, checkout_ViewModel.NumberOf200CHFCoins },
                    {100, checkout_ViewModel.NumberOf100CHFCoins },
                    {50, checkout_ViewModel.NumberOf50CHFCoins },
                    {20, checkout_ViewModel.NumberOf20CHFCoins },
                    {10, checkout_ViewModel.NumberOf10CHFCoins },
                    {5, checkout_ViewModel.NumberOf5CHFCoins },
                    {2, checkout_ViewModel.NumberOf2CHFCoins },
                    {1, checkout_ViewModel.NumberOf1CHFCoins },
                    {0.5, checkout_ViewModel.NumberOf50RapCoins },
                    {0.2, checkout_ViewModel.NumberOf20RapCoins },
                    {0.1, checkout_ViewModel.NumberOf10RapCoins },
                    {0.05, checkout_ViewModel.NumberOf5RapCoins }
                },
                checkout_ViewModel.Paid
                );

            string title = "Bargeldzahlung:";
            string message = "Dein Wechselgeld ist \n";
            foreach(KeyValuePair<double, int> coin in changeMoney)
            {
                message += coin.Value.ToString() + " mal " + coin.Key.ToString() + " Fr.\n";
            }

            MessageBox.Show(message, title);


            checkout_ViewModel.PetrolPumpModel = checkout_ViewModel.ChosenPump;
            //Pump gets reopened
            checkout_ViewModel.PetrolPumpModel.OpenPump(checkout_ViewModel.PetrolPumpModel);
            //As You pay the receipt gets made
            Receipt receipt = checkout_ViewModel.PetrolPumpModel.ReceiptOfPump;
            receipt.SaveData();



        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        public override bool CanExecute(object parameter)
        {
            //You can only pay when there is Something to pay and the client has given enough cash
            return checkout_ViewModel.Cost != 0 
                && checkout_ViewModel.Paid >= checkout_ViewModel.Cost
                && checkout_ViewModel.ChosenCheckout != null
                && checkout_ViewModel.ChosenPump != null;
        }

        public event EventHandler CanExecuteChanged;
    }
}
