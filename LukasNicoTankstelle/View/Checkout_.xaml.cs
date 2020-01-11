using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LukasNicoTankstelle.View
{
    /// <summary>
    /// Interaction logic for Checkout_.xaml
    /// </summary>
    public partial class Checkout_ : Window
    {
        public Checkout_()
        {
            InitializeComponent();
            Checkout_ViewModel checkout_ViewModel = new Checkout_ViewModel();
            DataContext = checkout_ViewModel;
        }
    }
}
