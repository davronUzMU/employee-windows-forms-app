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
    public partial class AddEmployeeForm : Form
    {
        private IEmployeeService _employeeService;
        private IAdminService _adminService;

        public AddEmployeeForm(IEmployeeService employeeServicee, IAdminService adminService)
        {
            InitializeComponent();
            _employeeService = employeeServicee;
            _adminService = adminService;
        }

        private void AddEmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void workAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void fullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void position_TextChanged(object sender, EventArgs e)
        {

        }

        private void workPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void personalPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void homePhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                var employeeRequest = new EmployeeRequestDTO
                {
                    WorkAddress = workAddress.Text.Trim(),
                    Fullname = fullName.Text.Trim(),
                    Position = position.Text.Trim(),
                    WorkPhone = workPhone.Text.Trim(),
                    PersonalPhone = personalPhone.Text.Trim(),
                    HomePhone = homePhone.Text.Trim(),
                    DateOfBirth = dateTimePicker1.Value.Date.ToUniversalTime() // UTC ga o'tkazish
                };

                var result = _employeeService.AddE(employeeRequest);
                MessageBox.Show("Employee successfully added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Hide();
                DashbortForm dashbortForm = new DashbortForm(_employeeService, _adminService);
                dashbortForm.Show();
                //this.Close();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException != null ? ex.InnerException.Message : "";
                MessageBox.Show("Xato: " + ex.Message + "\nInner Exception: " + inner, "Xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dashbortWay_Click(object sender, EventArgs e)
        {
            this.Hide();
            DashbortForm dashboard = new DashbortForm(_employeeService, _adminService);
            dashboard.Show();
        }
    }
}
