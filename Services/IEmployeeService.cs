using EmployeeApp.Payloads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Services
{
    public interface IEmployeeService
    {
        object AddE(EmployeeRequestDTO employeeRequestDTO);
        object DeleteE(int id);
        object GetEAll();
        object GetEById(int id);
        object UpdateE(int id,EmployeeRequestDTO employeeRequestDTO);
    }
}
