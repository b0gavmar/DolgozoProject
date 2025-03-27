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
        private int _payCycles;
        private readonly double _adokulcs = 0.27;

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
        public double Adokulcs => _adokulcs;
        public double Ado => Math.Round(_salary*Adokulcs);
        public int PayCycles => _payCycles;

        public void IncreaseSalary(int amount)
        {
            if(amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            _salary += amount;
            _payCycles++;
        }

        public void SetSalary(int amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Amount must be positive");
            }
            _salary = amount;
            _payCycles++;
        }


        public override string ToString()
        {
            return $"{Name} ({_email}) - {_salary} Ft";
        }
    }
}
