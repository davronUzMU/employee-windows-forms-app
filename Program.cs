using EmployeeApp.Data;
using EmployeeApp.Repositories;
using EmployeeApp.Services;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApp
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var optionsBuilder = new DbContextOptionsBuilder<AppDbContext>();
            optionsBuilder.UseNpgsql("Host=192.168.1.99;Database=Hodim_db;Username=postgres;Password=123456aa");

            var context = new AppDbContext(optionsBuilder.Options);

            IEmployeeRepository repository = new EmployeeRepository(context);
            IEmployeeService service = new EmployeeService(repository);

            IAdminRepository adminRepository = new AdminRepository(context);
            IAdminService adminService = new AdminService(adminRepository);

            Application.Run(new RootForm(service,adminService));

            //ApplicationConfiguration.Initialize();
            //Application.Run(new Form1());
        }
    }
}