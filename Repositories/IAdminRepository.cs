using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Repositories
{
    public interface IAdminRepository
    {
        List<AdminUser> GetAAll();
        AdminUser GetAById(int id);
        AdminUser AddA(AdminUser admin);
        AdminUser EditA(AdminUser admin);
        void DeleteA(int id);
    }
}
