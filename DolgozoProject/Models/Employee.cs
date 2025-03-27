using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoProject.Models
{
    public class Employee
    {
        private string _email;
        private int _salary;

        public Employee(string email, string name)
        {
            if(string.IsNullOrEmpty(email) || string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Email and name must be provided");
            }
            _email = email;
            Name = name;
        }

        public string Name { get; set; }
        public string Email => _email;
        public int Salary => _salary;
        public double Adokulcs => 0.27;
        public double Ado => _salary*Adokulcs;
        //public int TimesPaid { get; private set; } = 0;

        public void IncreaseSalary(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            _salary += amount;
        }

        public override string ToString()
        {
            return $"{Name}\n{_email}\n{_salary}\n{Ado}";
        }
    }
}
