using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using LukasNicoTankstelle.ViewModel;
using LukasNicoTankstelle.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LukasNicoTankstelle.Commands_Pump
{
    public class TankCommand : RelayCommand
    {
        private MainWindow_ViewModel mainViewModel;
        private PetrolPump_ViewModel petrolPumpViewModel;
        private Tap usedTap;

        public TankCommand(MainWindow_ViewModel newMainViewModel, PetrolPump_ViewModel newPetrolPumpViewModel)
        {
            mainViewModel = newMainViewModel;
            petrolPumpViewModel = newPetrolPumpViewModel;
        }

        public override void Execute(object parameter)
        {
            usedTap = parameter as Tap;
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            while (petrolPumpViewModel.IsPumping)
            {
                petrolPumpViewModel.LiterGetankt += 00.1;
                petrolPumpViewModel.Cost = petrolPumpViewModel.LiterGetankt * usedTap.PricePerLiter;
                Thread.Sleep(50);
            }

        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        public override bool CanExecute(object parameter)
        {
            return !petrolPumpViewModel.PetrolPumpModel.WasUsed;
        }

        public event EventHandler CanExecuteChanged;

    }
}
