

namespace _04._07
{
    internal interface ICargoService
    {
        void AddCustomer(Customer customer);
        void AddCourier(Courier courier);
        void CreateOrder(CargoOrder cargoOrder);
        void CompleteOrder(int id);

    }
}
