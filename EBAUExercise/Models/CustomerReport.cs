using System;
namespace EBAUExercise.Models
{
    public class CustomerReport
    {
        public CustomerReport(int customerId, int orderCount, decimal orderTotal)
        {
            CustomerId = customerId;
            OrderCount = orderCount;
            OrderTotal = orderTotal;

        }

        public int CustomerId { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderTotal { get; set; }
    }
}
