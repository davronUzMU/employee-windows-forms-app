using EmployeeApp.Data;
using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
       private readonly AppDbContext _context;
        public EmployeeRepository(AppDbContext context)
        {
            _context = context;
        }

        public Employee AddE(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
            return employee;
        }

        public void DeleteE(int id)
        {
            var employee = _context.Employees.Find(id);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }

        public Employee EditE(Employee employee)
        {
            _context.Employees.Update(employee);
            _context.SaveChanges();
            return employee;
        }

        public List<Employee> GetEAll()
        {
            return _context.Employees.ToList();
        }

        public Employee GetEById(int id)
        {
            return _context.Employees.Find(id);
    
        }
    }
}
