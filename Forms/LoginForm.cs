using EmployeeApp.Payloads;
using EmployeeApp.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAdminService _adminService;
        private readonly IEmployeeService _employeeService;


        public LoginForm(IAdminService adminService,IEmployeeService employeeService)
        {
            InitializeComponent();
            _adminService = adminService;
            _employeeService = employeeService;
        }


        private void txtFullname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                // Foydalanuvchidan ma'lumotlarni o'qish
                var fullname = txtFullname.Text.Trim();
                var username = txtUsername.Text.Trim();
                var password = txtPassword.Text.Trim();

                if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Iltimos, barcha maydonlarni to'ldiring.", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // DTO yaratish
                var adminDto = new AdminRequestDTO
                {
                    Fullname = fullname,
                    Username = username,
                    Password = password
                };

 
                int result = _adminService.loginSuccess(adminDto);

  
                MessageBox.Show("Login muvaffaqiyatli!", "Xabar", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
                DashbortForm dashboard = new DashbortForm(_employeeService,_adminService,result);
                dashboard.Show();

                this.Hide();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Login xatosi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Noma'lum xatolik yuz berdi: " + ex.Message, "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
