using KinoModel.ViewModel;
using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LukasNicoTankstelle.Commands
{
    public class TankCommand : RelayCommand
    {
        private MainWindow_ViewModel mainViewModel;
        private PetrolPump_ViewModel petrolPumpViewModel;

        public TankCommand(MainWindow_ViewModel newMainViewModel, PetrolPump_ViewModel newPetrolPumpViewModel)
        {
            mainViewModel = newMainViewModel;
            petrolPumpViewModel = newPetrolPumpViewModel;
        }

        public override void Execute(object parameter)
        {
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += worker_DoWork;
            worker.ProgressChanged += worker_ProgressChanged;
            worker.RunWorkerAsync();
        }

        void worker_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Thread.Sleep(500);
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
         
    }
}
