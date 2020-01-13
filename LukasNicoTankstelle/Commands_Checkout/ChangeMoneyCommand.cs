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


            
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return checkout_ViewModel.Cost != 0 
                && checkout_ViewModel.Paid >= checkout_ViewModel.Cost
                && checkout_ViewModel.ChosenCheckout != null
                && checkout_ViewModel.ChosenPump != null;
        }

        public event EventHandler CanExecuteChanged;
    }
}
