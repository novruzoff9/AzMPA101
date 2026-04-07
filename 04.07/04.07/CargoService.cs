namespace _04._07
{
    internal class CargoService : ICargoService
    {
       static Customer[] customers = new Customer[0];
        static Courier[] couriers = new Courier[0];
        static CargoOrder[] cargoOrders = new CargoOrder[0];

        public void AddCourier(Courier courier)
        {
            Array.Resize(ref couriers, couriers.Length + 1);
            couriers[couriers.Length - 1] = courier;
        }

        public void AddCustomer(Customer customer)
        {
            Array.Resize(ref customers, customers.Length + 1);
            customers[customers.Length - 1] = customer;
         }

        public void CompleteOrder(int id)
        {

            
            

        }

        public void CreateOrder(CargoOrder cargoOrder)
        {
            Customer existedCustomer = null;
            Courier existedCourier = null;
            foreach (Customer customer in customers)
            {
                if (customer.Id == cargoOrder.CustomerId)
                {
                    existedCustomer = customer;
                }
            }
            if (existedCustomer == null)
            {
                Console.WriteLine("musteri tapilmadi");
                return;
            }

            foreach (Courier courier in couriers)
            {
                if (courier.Id == cargoOrder.CourierId)
                {
                    existedCourier = courier;
                }
            }
            if (existedCourier == null)
            {
                Console.WriteLine("kuryer tapilmadi");
                return;
            }


            if (existedCourier.IsAvailable == false)
            {
                Console.WriteLine("elcatan deyil");
                return;
            }
            Array.Resize(ref cargoOrders, cargoOrders.Length + 1);
            cargoOrders[cargoOrders.Length - 1] = cargoOrder;

            existedCourier.IsAvailable = false;
        }
    }
}
