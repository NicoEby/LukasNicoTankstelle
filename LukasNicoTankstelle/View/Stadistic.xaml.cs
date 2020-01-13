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
    /// Interaction logic for Stadistic.xaml
    /// </summary>
    public partial class Stadistic : UserControl
    {
        public Stadistic()
        {
            InitializeComponent();
            Stadistic_ViewModel stadistic_ViewModel = new Stadistic_ViewModel();
            DataContext = stadistic_ViewModel;
        }
    }
}
