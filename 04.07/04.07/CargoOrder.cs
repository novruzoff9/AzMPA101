using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04._07
{
    internal class CargoOrder
    {
        private static int _idCounter = 0;
        public int Id { get; set; }
        public int CustomerId {  get; set; }
        public int CourierId { get; set; }
        public int TotalAmount { get; set; }
        public OrderStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public CargoOrder(int customerid,int courerid,int totalamount)
        {
            Id =++_idCounter;
            CustomerId = customerid;
            TotalAmount = totalamount;
            Status=OrderStatus.Created;
            CreatedAt = DateTime.Now;
        }

        public void  UpdateStatus(OrderStatus newStatus)
        {
            if (Status == OrderStatus.Cancelled || Status == OrderStatus.Delivered)
            {
                Console.WriteLine("statusu deyismek mumkun olmadi");
                return;
            }
            Status = newStatus;
        }
    }
}
