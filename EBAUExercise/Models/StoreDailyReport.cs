using System;
namespace EBAUExercise.Models
{
    public class StoreDailyReport
    {
        public StoreDailyReport(string orderDate, int orderCount, decimal orderTotal)
        {
            OrderDate = orderDate;
            OrderCount = orderCount;
            OrderTotal = orderTotal;
        }

        public string OrderDate { get; set; }
        public int OrderCount { get; set; }
        public decimal OrderTotal { get; set; }  
    }
}
