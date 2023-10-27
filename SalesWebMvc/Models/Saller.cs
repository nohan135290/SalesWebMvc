using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models
{
    public class Saller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; }
        public ICollection<SalerRecord> Sales { get; set; } = new List<SalerRecord>();

        public Saller()
        {
        }
        //Constructor
        public Saller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }
        //ADD Sallers
        public void AddSales(SalerRecord sr)
        {
            Sales.Add(sr);
        }
        //Remove Sallers
        public void RemoveSales(SalerRecord sr)
        {
            Sales.Remove(sr);
        }
        //Total Sallers sum
        public double TotalSallers(DateTime initial, DateTime final)
        {
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount);
        }
    }
}
