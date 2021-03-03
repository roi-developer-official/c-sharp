using System;

namespace interfaces
{
    partial class Program
    {
    
            public class Order
            {
                public bool IsShipped;
                public DateTime DatePlaced;
                public Shipment Shipment;
                public float TotalPrice;
            }
        
    }
}
