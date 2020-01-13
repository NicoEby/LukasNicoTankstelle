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
using System.Windows;
using System.Windows.Input;

namespace LukasNicoTankstelle.ViewModel
{
    public class Checkout_ViewModel : ModelBase
    {
        private List<PetrolPump> petrolPumps;
        public PetrolStation PetrolStations { get; set; } = PetrolStation.getInstance();
        static List<Checkout_ViewModel> allCheckoutVMs = new List<Checkout_ViewModel>();
        public List<PetrolPump> PetrolPumps
        {
            get { return petrolPumps; }
            set
            {
                petrolPumps = value;
                OnPropertyChanged(nameof(PetrolPumps));

            }

        }
        //public List<PetrolPump> PetrolPumps { get; set; }
        public ObservableCollection<Checkout> CheckOuts { get; set; }

        private double cost = 100;
        private double paid = 0;
        private int numberOf5RapCoins = 0;
        private int numberOf10RapCoins = 0;
        private int numberOf20RapCoins = 0;
        private int numberOf50RapCoins = 0;
        private int numberOf1CHFCoins = 0;
        private int numberOf2CHFCoins = 0;
        private int numberOf5CHFCoins = 0;
        private int numberOf10CHFCoins = 0;
        private int numberOf20CHFCoins = 0;
        private int numberOf50CHFCoins = 0;
        private int numberOf100CHFCoins = 0;
        private int numberOf200CHFCoins = 0;
        private ICommand paymentCommand;
        private ICommand creditCardCommand;
        private ICommand cancelPaymentCommand;
        private ICommand changeMoneyCommand;
        private ICommand refreshCommand;
        private ICommand receiptCommand;
        private Boolean isPayingCreditCard;
        private Boolean isPaying=false;



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
        public ICommand RefreshCommand
        {
            get { return refreshCommand; }
            set { refreshCommand = value; }
        }
        public ICommand ReceiptCommand
        {
            get { return receiptCommand; }
            set { receiptCommand = value; }
        }

        public PetrolPump PetrolPumpModel { get; set; }


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

        public int NumberOf5RapCoins
        {
            get { return numberOf5RapCoins; }
            set
            {
                numberOf5RapCoins = value;
                OnPropertyChanged(nameof(numberOf5RapCoins));

            }
        }
        public int NumberOf10RapCoins
        {
            get { return numberOf10RapCoins; }
            set
            {
                numberOf10RapCoins = value;
                OnPropertyChanged(nameof(numberOf10RapCoins));

            }
        }
        public int NumberOf20RapCoins
        {
            get { return numberOf20RapCoins; }
            set
            {
                numberOf20RapCoins = value;
                OnPropertyChanged(nameof(numberOf20RapCoins));

            }
        }
        public int NumberOf50RapCoins
        {
            get { return numberOf50RapCoins; }
            set
            {
                numberOf50RapCoins = value;
                OnPropertyChanged(nameof(numberOf50RapCoins));

            }
        }
        public int NumberOf1CHFCoins
        {
            get { return numberOf1CHFCoins; }
            set
            {
                numberOf1CHFCoins = value;
                OnPropertyChanged(nameof(numberOf1CHFCoins));

            }
        }
        public int NumberOf2CHFCoins
        {
            get { return numberOf2CHFCoins; }
            set
            {
                numberOf2CHFCoins = value;
                OnPropertyChanged(nameof(numberOf2CHFCoins));

            }
        }
        public int NumberOf5CHFCoins
        {
            get { return numberOf5CHFCoins; }
            set
            {
                numberOf5CHFCoins = value;
                OnPropertyChanged(nameof(numberOf5CHFCoins));

            }
        }
        public int NumberOf10CHFCoins
        {
            get { return numberOf10CHFCoins; }
            set
            {
                numberOf10CHFCoins = value;
                OnPropertyChanged(nameof(numberOf10CHFCoins));

            }
        }
        public int NumberOf20CHFCoins
        {
            get { return numberOf20CHFCoins; }
            set
            {
                numberOf20CHFCoins = value;
                OnPropertyChanged(nameof(numberOf20CHFCoins));

            }
        }
        public int NumberOf50CHFCoins
        {
            get { return numberOf50CHFCoins; }
            set
            {
                numberOf50CHFCoins = value;
                OnPropertyChanged(nameof(numberOf50CHFCoins));

            }
        }
        public int NumberOf100CHFCoins
        {
            get { return numberOf100CHFCoins; }
            set
            {
                numberOf100CHFCoins = value;
                OnPropertyChanged(nameof(numberOf100CHFCoins));

            }
        }
        public int NumberOf200CHFCoins
        {
            get { return numberOf200CHFCoins; }
            set
            {
                numberOf200CHFCoins = value;
                OnPropertyChanged(nameof(numberOf200CHFCoins));

            }
        }

        public static void PumpWasUsedVM (object sender, EventArgs e)
        {
            foreach(Checkout_ViewModel checkoutVM in allCheckoutVMs)
            {
                checkoutVM.PetrolPumps = checkoutVM.PetrolStations.GetAllUsedPumps();
            }
        }

        public Checkout_ViewModel()
        {
            allCheckoutVMs.Add(this);

            CheckOuts = new ObservableCollection<Checkout>();
            foreach (Checkout b in PetrolStations.Checkouts)
            {
                CheckOuts.Add(b);
            }


            PaymentCommand = new PaymentCommand(this);
            CreditCardCommand = new CreditCardCommand(this);
            CancelPaymentCommand = new CancelPaymentCommand(this);
            ChangeMoneyCommand = new ChangeMoneyCommand(this);
            RefreshCommand = new RefreshCommand(this);
            ReceiptCommand = new ReceiptCommand(this);


        }
    }
}
