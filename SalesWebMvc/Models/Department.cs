using System.Collections.Generic;
using System;
using System.Linq;

namespace SalesWebMvc.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Saller> Sallers { get; set; } = new List<Saller>();

        public Department()
        {
        }
        //Department Constructor
        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }
        //Add Saller
        public void AddSaller(Saller saller)
        {
            Sallers.Add(saller);
        }
        //Total Saller
        public double TotalSaller(DateTime initial, DateTime final)
        {
            return Sallers.Sum(saller => saller.TotalSallers(initial, final));
        }
    }
}
