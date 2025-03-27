using DolgozoProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozoProject.Repos
{
    public class DolgozokRepo
    {
        private readonly DolgozokContext _context;

        public DolgozokRepo(DolgozokContext context)
        {
            _context = context;
        }

        public async Task<int> GetNumberOfEmployees()
        {
            return await _context.Dolgozok.CountAsync();
        }

        public async Task<List<Employee>> GetAll()
        {
            return await _context.Dolgozok.ToListAsync();
        }

        public async Task<List<Employee>> GetAllHigherThan(int number)
        {
            return await _context.Dolgozok.Where(d => d.Salary > number).ToListAsync();
        }

        public async Task<List<Employee>> OrderedBySalary()
        {
            return await _context.Dolgozok.OrderByDescending(d => d.Salary).ToListAsync();
        }

        public void AvgAndSum()
        {
            Console.WriteLine(_context.Dolgozok.Average(d => d.Salary));
            Console.WriteLine(_context.Dolgozok.Sum(d => d.Salary));
        }

        public async Task<Dictionary<string,int>> GroupBySalary()
        {
            var d = new Dictionary<string, int>{
                {"400000 Ft alatt",0 },
                { "400000 - 500000 Ft között",0 },
                { "500000 Ft felett",0 },
            };

            var employees = _context.Dolgozok.ToListAsync();
            foreach (var e in employees.Result)
            {
                if (e.Salary < 400000)
                {
                    d["400000 Ft alatt"]++;
                }
                else if (e.Salary < 500000)
                {
                    d["400000 - 500000 Ft között"]++;
                }
                else
                {
                    d["500000 Ft felett"]++;
                }
            }
            return d;
            
        }
    }
}
