using SalesWebMvc.Models.Enums;
using System;


namespace SalesWebMvc.Models
{
    public class SalerRecord
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public double Amount { get; set; }
        public SalerRecord Status { get; set; }
        public Saller Saller { get; set; }

        public SalerRecord()
        {
        }

        public SalerRecord(int id, DateTime date, double amount, SalerRecord status, Saller saller)
        {
            Id = id;
            Date = date;
            Amount = amount;
            Status = status;
            Saller = saller;
        }
    }
}
