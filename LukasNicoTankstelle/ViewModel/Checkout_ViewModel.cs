using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Commands;
using LukasNicoTankstelle.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LukasNicoTankstelle.ViewModel
{
    public class Checkout_ViewModel: ModelBase
    {
        public PetrolStation PetrolStations { get; set; } = PetrolStation.getInstance();
        public ObservableCollection<Checkout> CheckOuts { get; set; }
        public ObservableCollection<PetrolPump> PetrolPumps { get; set; }

        private double cost =100;
        private double paid = 0;
        private ICommand paymentCommand;
        private ICommand creditCardCommand;



        public ICommand PaymentCommand
        {
            get { return paymentCommand; }
            set { paymentCommand = value; }
        }
        public ICommand CreditCardCommand
        {
            get { return creditCardCommand; }
            set { creditCardCommand = value; }
        }

        public double Cost
        {
            get { return cost; }
            set
            {
                cost = value;
            }
        }

        public double Paid
        {
            get { return paid; }
            set
            {
                paid = value;
                OnPropertyChanged(nameof(Paid));

            }
        }

        




        public Checkout_ViewModel()
        {
            CheckOuts = new ObservableCollection<Checkout>();
            foreach (Checkout b in PetrolStations.Checkouts)
            {
                CheckOuts.Add(b);
            }


            PaymentCommand = new PaymentCommand(this);
            CreditCardCommand = new CreditCardCommand(this);


        }

        private void Do_Payment(object coin)
        {
            Paid = Paid + Convert.ToDouble(coin);
        }


        private void Do_PayWithCard(object obj)
        {

        }




    }
}
