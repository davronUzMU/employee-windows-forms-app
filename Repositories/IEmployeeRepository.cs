using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Repositories
{
    public interface IEmployeeRepository
    {
        List<Employee> GetEAll();
        Employee GetEById(int id);
        Employee AddE(Employee employee);
        Employee EditE(Employee employee);
        void DeleteE(int id);
    }
}
