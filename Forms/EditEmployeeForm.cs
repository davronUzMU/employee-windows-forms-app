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
    public partial class EditEmployeeForm : Form
    {
        private IEmployeeService _employeeService;
        private IAdminService _adminService;
        private int _emp_id;

        public EditEmployeeForm(IEmployeeService employeeService, IAdminService adminService, int emp_id)
        {
            InitializeComponent();
            this._employeeService = employeeService;
            this._adminService = adminService;
            this._emp_id = emp_id;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void dashbortWay_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashbortForm dashboard = new DashbortForm(_employeeService, _adminService);
            dashboard.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void editEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                var updateDto = new EmployeeRequestDTO
                {
                    WorkAddress= textBox1.Text.Trim(),
                    Fullname = textBox2.Text.Trim(),
                    Position = textBox3.Text.Trim(),
                    WorkPhone = textBox4.Text.Trim(),
                    PersonalPhone = textBox5.Text.Trim(),
                    HomePhone = textBox6.Text.Trim(),
                    DateOfBirth = dateTimePicker1.Value.Date.ToUniversalTime()
                };

                _employeeService.UpdateE(_emp_id, updateDto);

                MessageBox.Show("Xodim ma'lumotlari yangilandi!", "Muvaffaqiyatli", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xatolik: {ex.Message}", "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
