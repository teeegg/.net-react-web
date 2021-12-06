using System;
using System.Collections.Generic;
using System.Linq;
using EBAUExercise.Models;
using EBAUExercise.Repository;

namespace EBAUExercise.Services
{
    public class ReportService
    {
        private readonly SampleDataRepository _sampleDataRepository;

        public ReportService(SampleDataRepository sampleDataRepository)
        {
            _sampleDataRepository = sampleDataRepository;
        }

        /// <summary>
        /// Build and output a list of data that breaks down the data by customer id, taking count of orders and summing 'order total'.
        /// </summary>
        public List<CustomerReport> CustomerReport()
        {
            var dataset = _sampleDataRepository.GetDataset;

            Dictionary<int, CustomerReport> result = new Dictionary<int, CustomerReport>();

            foreach(CustomerOrder order in dataset)
            {
                if (!result.ContainsKey(order.CustomerId))
                    result.Add(order.CustomerId, new CustomerReport(order.CustomerId, 1, order.OrderTotal));
                else
                {
                    result[order.CustomerId].OrderCount += 1;
                    result[order.CustomerId].OrderTotal += order.OrderTotal;
                }
            }

            return result.Values.OrderBy(v => v.CustomerId).ToList();
        }

        /// <summary>
        /// Build and output a list of data that shows the number of orders by date and a sum of 'order total'.
        /// </summary>
        public List<StoreDailyReport> StoreDailyReport()
        {
            var dataset = _sampleDataRepository.GetDataset;

            Dictionary<string, StoreDailyReport> result = new Dictionary<string, StoreDailyReport>();

            foreach (CustomerOrder order in dataset)
            {
                if (!result.ContainsKey(order.OrderDate.Date.ToShortDateString()))
                    result.Add(order.OrderDate.Date.ToShortDateString(), new StoreDailyReport(order.OrderDate.Date.ToShortDateString(), 1, order.OrderTotal));
                else
                {
                    result[order.OrderDate.Date.ToShortDateString()].OrderCount += 1;
                    result[order.OrderDate.Date.ToShortDateString()].OrderTotal += order.OrderTotal;
                }
            }

            return result.Values.OrderBy(v => v.OrderDate).ToList();

        }
    }
}