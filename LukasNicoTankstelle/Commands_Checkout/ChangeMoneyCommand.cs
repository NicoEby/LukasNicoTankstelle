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
                List<double> cost = checkout_ViewModel.CheckOuts[1].Cash.Keys.ToList();
                string message = "Zahlung erfolgreich beendet. Sie bekommen jetzt ";
                foreach (double cash in cost.OrderByDescending(i=>i))
                {
                    double amount = Math.Floor(changeMoney / cash);
                    
                    if (amount != 0 && checkout_ViewModel.CheckOuts[1].Cash.FirstOrDefault(s => s.Key == cash).Value > amount)
                    {
                        changeMoney -= (amount * cash);

                        if (cash < 0)
                        {
                            double coin = cash * 100;
                            message += amount + " " + coin + " Rappen"; 
                        }
                        else
                        {
                            message += amount + " " + cash + " CHF";
                        }

                        //checkout_ViewModel.CheckOuts[1].Cash.Select(s => s.Key == cash) -= 


                    }                   
                    
                }
                if (changeMoney == 0)
                {
                    string title = "Gratuliere";
                    MessageBox.Show(message, title);
                    checkout_ViewModel.PetrolPumpModel.OpenPump(checkout_ViewModel.PetrolPumpModel);

                }
                else
                {
                    string title = "Error";
                    string message2 = "Wir können sie nicht bezahlen";
                    MessageBox.Show(message2, title);
                }

                checkout_ViewModel.NumberOf5RapCoins = 0;
                checkout_ViewModel.NumberOf10RapCoins = 0;
                checkout_ViewModel.NumberOf20RapCoins = 0;
                checkout_ViewModel.NumberOf50RapCoins = 0;
                checkout_ViewModel.NumberOf1CHFCoins = 0;
                checkout_ViewModel.NumberOf2CHFCoins = 0;
                checkout_ViewModel.NumberOf5CHFCoins = 0;
                checkout_ViewModel.NumberOf10CHFCoins = 0;
                checkout_ViewModel.NumberOf20CHFCoins = 0;
                checkout_ViewModel.NumberOf50CHFCoins = 0;
                checkout_ViewModel.NumberOf100CHFCoins = 0;
                checkout_ViewModel.NumberOf200CHFCoins = 0;

            }
            else
            {
                double amountToPay = checkout_ViewModel.Cost - checkout_ViewModel.Paid;
                string message = $"Sie haben nicht alles Bezahlt. Sie müssen noch {amountToPay}CHF zu bezahlen";
                string title = "Warnung ";
                MessageBox.Show(message, title);
            }


            
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
