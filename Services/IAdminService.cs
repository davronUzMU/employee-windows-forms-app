using EmployeeApp.Payloads;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Services
{
    public interface IAdminService
    {
        object AddA(AdminRequestDTO adminRequestDTO);
        object DeleteA(int id);
        object GetA();
        object GetAById(int id);
        object UpdateA(int id, AdminRequestDTO adminRequestDTO);

        int loginSuccess(AdminRequestDTO adminRequestDTO);

        //object loginSuccess(AdminRequestDTO adminRequestDTO);
    }
}
