using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LukasNicoTankstelle.Class
{
    public class Order
    {
        static int nrOfInstances = 0;
        private int id;
        private DateTime whenOrdered;
        private DateTime deliverDate;
        private DateTime whenDelivered;
        private Boolean delivered;
        private float quantityOrdered;
        private float quantityDelivered=0;
        private GasolineType gasolineType;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
            }
        }

        public DateTime WhenOrdered
        {
            get { return whenOrdered; }
            set
            {
                whenOrdered = DateTime.Today;
            }
        }

        public DateTime DeliverDate
        {
            get { return deliverDate; }
            set
            {
                deliverDate = value;
            }
        }

        public DateTime Whendelivered
        {
            get { return whenDelivered; }
            set
            {
                whenDelivered = value;
            }
        }

        public Boolean Delivered
        {
            get { return QuantityOrdered<= QuantityDelivered; }

        }

        public float QuantityOrdered
        {
            get { return quantityOrdered; }
            set
            {
                quantityOrdered = value;
            }
        }
        public float QuantityDelivered
        {
            get { return quantityDelivered; }
            set
            {
                quantityDelivered = value;
            }
        }

        public GasolineType GasolineType
        {
            get { return gasolineType; }
            set
            {
                gasolineType = value;
            }
        }
        public Order(DateTime deliverDate, DateTime whenDelivered,float quantityOrdered,GasolineType gasolineType)
        {
            Id = Order.nrOfInstances;
            Order.nrOfInstances++;
            DeliverDate = deliverDate;
            Whendelivered = whenDelivered;
            QuantityDelivered = quantityOrdered;
            GasolineType = gasolineType;

        }


    }
}
