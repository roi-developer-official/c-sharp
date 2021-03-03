using System;

namespace interfaces
{
    partial class Program
    {
        public class OrderProcessor
        {
            //this is a dependancy that we want to remove.
            //private readonly ShippingCalculator _shippingCalculator;

            private readonly IShippingCalculator _shippingCalculator;
            public OrderProcessor(IShippingCalculator shippingCalculator)
            {
                //_shippingCalculator = new ShippingCalculator();
                _shippingCalculator = shippingCalculator;
            }

            public void Process(Order order)
            {
                if (order.IsShipped)
                {
                    throw new InvalidOperationException("this order is already processed.");
                }
                    order.Shipment = new Shipment
                    {
                        Cost = _shippingCalculator.CalculateShipping(order),
                        ShppingDate = DateTime.Today.AddDays(1)
                    };
                }

            }
        }
    }

