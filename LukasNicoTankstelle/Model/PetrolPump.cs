using LukasNicoTankstelle.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LukasNicoTankstelle.ViewModel.Checkout_ViewModel;

namespace LukasNicoTankstelle.Class
{
    public class PetrolPump
    {
        private string number;
        private Boolean wasUsed;

        private List<Tap> taps;
        private double liter = 1;
        private double amountOwed;

        public Receipt ReceiptOfPump { get; set; }

        public string Number
        {
            get { return number; }
            set
            {
                number = value;
            }
        }
        public List<Tap> Taps
        {
            get { return taps; }
            set
            {
                taps = value;
            }
        }
        public double Liter
        {
            get { return liter; }
            set
            {
                liter = value;
            }
        }
        public Boolean WasUsed
        {
            get { return wasUsed; }
            set
            {
                wasUsed = value;
            }
        }

        public double AmountOwned
        {
            get { return amountOwed; }
            set
            {
                amountOwed = value;
            }
        }
        

        public PetrolPump(string number, List<Tap> taps)
        {
            Number = number;
            Taps = taps;
            WasUsed = false;
            PumpWasUsed += Checkout_ViewModel.PumpWasUsedVM;
            PumpIsPayed += Checkout_ViewModel.PumpIsPayedVM;
            PumpIsPayed += PetrolPump_ViewModel.PumpIsPayedVM;
        }

        public event EventHandler PumpWasUsed;
        public event EventHandler PumpIsPayed;

        //Dieser Event teilt mit das sich das Model verändert hat, dies wird gebraucht um das ViewModel und den View mit dem Model zu abzugleichen
        protected virtual void OnPumpWasUsed(EventArgs e)
        {
            EventHandler handler = PumpWasUsed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        protected virtual void OnPumpIsPayed(EventArgs e)
        {
            EventHandler handler = PumpIsPayed;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        /// <summary>
        /// After pumping the pump is blocked and several parameters are recorded
        /// </summary>
        /// <param name="usedPump"></param>
        /// <param name="usedGasolineType"></param>
        /// <param name="litersPumped"></param>
        /// <param name="amountOwed"></param>
        public void FinishedPumping(PetrolPump usedPump, GasolineType usedGasolineType, double litersPumped, double amountOwed)
        {  
            usedPump.WasUsed = true;
            usedPump.AmountOwned = amountOwed;
            Tap usedTap = Taps.Where(x => x.GasolineType == usedGasolineType).FirstOrDefault();
            usedTap.LiterPerTank -= litersPumped;
            OnPumpWasUsed(EventArgs.Empty);
        }

        /// <summary>
        /// After payment was received the open is reset and reopened
        /// </summary>
        /// <param name="usedPump"></param>
        public void OpenPump(PetrolPump usedPump)
        {
            usedPump.WasUsed = false;
            usedPump.AmountOwned = 0;
            OnPumpIsPayed(EventArgs.Empty);
        }

    }
}
