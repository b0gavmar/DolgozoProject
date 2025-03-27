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
    }
}
