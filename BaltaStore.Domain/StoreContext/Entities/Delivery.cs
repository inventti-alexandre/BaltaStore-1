using BaltaStore.Domain.StoreContext.Enums;
using System;

namespace BaltaStore.Domain.StoreContext.Entities
{
    public class Delivery
    {
        //ctor
        public Delivery(DateTime estimatedDeliveryDate)

        {
            CreateDate = DateTime.Now;
            EstimatedDeliveryDate = estimatedDeliveryDate;
            Status = EDeliveryStatus.Waiting;

        }
        public DateTime CreateDate { get; private set; }
        public DateTime EstimatedDeliveryDate { get; private set; }
        public EDeliveryStatus Status { get; private set; }

        public void Ship()
        {
            Status = EDeliveryStatus.Shipped;
        }
        public void Cancel()
        {
            Status = EDeliveryStatus.Canceled;
        }
    }
}
