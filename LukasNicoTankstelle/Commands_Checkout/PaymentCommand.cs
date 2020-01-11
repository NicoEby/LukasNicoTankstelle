using KinoModel.ViewModel;
using LukasNicoTankstelle.ViewModel;
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
            checkout_ViewModel.Paid= checkout_ViewModel.Paid + Convert.ToDouble(parameter);
            checkout_ViewModel.CheckOuts[1].Cash[Convert.ToDouble(parameter)] +=1;
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
