using EmployeeApp.Data;
using EmployeeApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Repositories
{
    public class AdminRepository : IAdminRepository
    {
        private readonly AppDbContext _context;
        public AdminRepository(AppDbContext context)
        {
            _context = context;
        }

        public AdminUser AddA(AdminUser admin)
        {
            _context.AdminUsers.Add(admin);
            _context.SaveChanges();
            return admin;
        }

        public void DeleteA(int id)
        {
            var admin = _context.AdminUsers.Find(id);
            if (admin != null)
            {
                _context.AdminUsers.Remove(admin);
                _context.SaveChanges();
            }
        }

        public AdminUser EditA(AdminUser admin)
        {
            _context.AdminUsers.Update(admin);
            _context.SaveChanges();
            return admin;
        }

        public List<AdminUser> GetAAll()
        {
            return _context.AdminUsers.ToList();
        }

        public AdminUser GetAById(int id)
        {
            return _context.AdminUsers.Find(id);
        }
    }
}
