using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.Commands;
using LukasNicoTankstelle.Commands_Checkout;
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
        //private int numberOf5RapCoins;
        //private int numberOf10RapCoins ;
        //private int numberOf20RapCoins ;
        //private int numberOf50RapCoins ;
        //private int numberOf1CHFCoins ;
        //private int numberOf2CHFCoins ;
        //private int numberOf5CHFCoins ;
        //private int numberOf10CHFCoins ;
        //private int numberOf20CHFCoins ;
        //private int numberOf50CHFCoins ;
        //private int numberOf100CHFCoins ;
        //private int numberOf200CHFCoins ;
        private ICommand paymentCommand;
        private ICommand creditCardCommand;
        private ICommand cancelPaymentCommand;
        private ICommand changeMoneyCommand;



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
        public ICommand CancelPaymentCommand
        {
            get { return cancelPaymentCommand; }
            set { cancelPaymentCommand = value; }
        }
        public ICommand ChangeMoneyCommand
        {
            get { return changeMoneyCommand; }
            set { changeMoneyCommand = value; }
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

        //public double Paid
        //{
        //    get { return paid; }
        //    set
        //    {
        //        paid = value;
        //        OnPropertyChanged(nameof(Paid));

        //    }
        //}

        //public int NumberOf5RapCoins { get{return numberOf5RapCoins }
        //    set { } }

        //public int NumberOf10RapCoins { get{ } set{ } }

        //public int NumberOf20RapCoins { get{ } set{ } }
        //public int NumberOf50RapCoins { get{ } set{ } }
        //public int NumberOf1CHFCoins { get{ } set{ } }
        //public int NumberOf2CHFCoins { get{ } set{ } }
        //public int NumberOf5CHFCoins { get{ } set{ } }
        //public int NumberOf10CHFCoins { get{ } set{ } }
        //public int NumberOf20CHFCoins { get{ } set{ } }
        //public int NumberOf50CHFCoins { get{ } set{ } }
        //public int NumberOf100CHFCoins { get{ } set{ } }
        //public int NumberOf200CHFCoins { get{ } set{ } }







        public Checkout_ViewModel()
        {
            CheckOuts = new ObservableCollection<Checkout>();
            foreach (Checkout b in PetrolStations.Checkouts)
            {
                CheckOuts.Add(b);
            }


            PaymentCommand = new PaymentCommand(this);
            CreditCardCommand = new CreditCardCommand(this);
            CancelPaymentCommand = new CancelPaymentCommand(this);
            ChangeMoneyCommand = new ChangeMoneyCommand(this);


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
