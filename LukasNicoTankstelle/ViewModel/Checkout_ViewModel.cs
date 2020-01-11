using KinoModel.ViewModel;
using LukasNicoTankstelle.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.ViewModel
{
    public class Checkout_ViewModel: ModelBase
    {
        public PetrolStation PetrolStations { get; set; } = PetrolStation.getInstance();

        

    }
}
