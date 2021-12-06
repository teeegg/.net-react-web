using System;

namespace EBAUExercise.Models
{
    public class CustomerOrder
    {
        public CustomerOrder(int customerId, int orderId, decimal orderTotal, DateTime orderDate)
        {
            CustomerId = customerId;
            OrderId = orderId;
            OrderTotal = orderTotal;
            OrderDate = orderDate;
        }

        public int CustomerId { get; set; }
        public int OrderId { get; set; }
        public decimal OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
    }
}