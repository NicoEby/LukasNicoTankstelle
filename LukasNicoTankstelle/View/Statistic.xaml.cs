﻿using LukasNicoTankstelle.ViewModel;
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
    public partial class Statistic : UserControl
    {
        public Statistic()
        {
            InitializeComponent();
            Statistic_ViewModel statistic_ViewModel = new Statistic_ViewModel();
            DataContext = statistic_ViewModel;
        }
    }
}