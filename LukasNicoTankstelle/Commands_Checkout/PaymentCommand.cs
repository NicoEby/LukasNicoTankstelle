﻿using KinoModel.ViewModel;
using LukasNicoTankstelle.ViewModel;
using LukasNicoTankstelle.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Commands
{
    public class PaymentCommand:RelayCommand
    {
        private Checkout_ViewModel checkout_ViewModel;

        public PaymentCommand(Checkout_ViewModel newcheckout_ViewModel)
        {
            checkout_ViewModel = newcheckout_ViewModel;
        }

        public override void Execute(object parameter)
        {
            Double m = Convert.ToDouble(parameter)/100;
            checkout_ViewModel.Paid= checkout_ViewModel.Paid + m;
            checkout_ViewModel.CheckOuts[1].Cash[m] +=1;

            //Dieser Switchcase speichert welches Münz der Kunde gegeben hat um die Münze und Noten in der Kasse abspeichern zu können
            switch (m)
            {
                case 0.05:
                    checkout_ViewModel.NumberOf5RapCoins += 1;
                    break;
                case 0.1:
                    checkout_ViewModel.NumberOf10RapCoins += 1;
                    break;
                case 0.2:
                    checkout_ViewModel.NumberOf20RapCoins += 1;
                    break;
                case 0.5:
                    checkout_ViewModel.NumberOf50RapCoins += 1;
                    break;
                case 1:
                    checkout_ViewModel.NumberOf1CHFCoins += 1;
                    break;
                case 2:
                    checkout_ViewModel.NumberOf2CHFCoins += 1;
                    break;
                case 5:
                    checkout_ViewModel.NumberOf5CHFCoins += 1;
                    break;
                case 10:
                    checkout_ViewModel.NumberOf10CHFCoins += 1;
                    break;
                case 20:
                    checkout_ViewModel.NumberOf20CHFCoins += 1;
                    break;
                case 50:
                    checkout_ViewModel.NumberOf50CHFCoins += 1;
                    break;
                case 100:
                    checkout_ViewModel.NumberOf100CHFCoins += 1;
                    break;
                case 200:
                    checkout_ViewModel.NumberOf200CHFCoins += 1;
                    break;


                default:
                    break;
            }
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return checkout_ViewModel.ChosenPump != null;
        }

        public event EventHandler CanExecuteChanged;


    }
}
