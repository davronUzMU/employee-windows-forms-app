using EmployeeApp.Forms;
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

namespace EmployeeApp
{
    public partial class RootForm : Form
    {
        private readonly IEmployeeService _employeeService;

        private readonly IAdminService _adminService;

        public RootForm(IEmployeeService employeeService, IAdminService adminService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _adminService = adminService;
        }


        private void RootForm_Load(object sender, EventArgs e)
        {
            cmbFilter.Items.AddRange(new string[] { "To'liq joyi", "F.I.O", "Lavozim", "Ish telefoni", "Shaxsiy teleni", "Uy telefoni" });
            cmbFilter.SelectedIndex = 0;
            LoadAllEmployees();
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = cmbFilter.SelectedItem.ToString();
                var searchText = txtSearch.Text.Trim().ToLower();

                var employeeList = _employeeService.GetEAll() as List<EmployeeResponseDTO>;

                if (string.IsNullOrEmpty(searchText))
                {
                    dgvEmployees.DataSource = employeeList; // bo'sh bo'lsa hammasini ko'rsatadi
                    return;
                }

                IEnumerable<EmployeeResponseDTO> filteredList = new List<EmployeeResponseDTO>();

                switch (filter)
                {
                    case "To'liq joyi":
                        filteredList = employeeList.Where(e => e.WorkAddress != null && e.WorkAddress.ToLower().Contains(searchText));
                        break;
                    case "F.I.O":
                        filteredList = employeeList.Where(e => e.Fullname != null && e.Fullname.ToLower().Contains(searchText));
                        break;
                    case "Lavozim":
                        filteredList = employeeList.Where(e => e.Position != null && e.Position.ToLower().Contains(searchText));
                        break;
                    case "Ish telefoni":
                        filteredList = employeeList.Where(e => e.WorkPhone != null && e.WorkPhone.ToLower().Contains(searchText));
                        break;
                    case "Shaxsiy teleni":
                        filteredList = employeeList.Where(e => e.PersonalPhone != null && e.PersonalPhone.ToLower().Contains(searchText));
                        break;
                    case "Uy telefoni":
                        filteredList = employeeList.Where(e => e.HomePhone != null && e.HomePhone.ToLower().Contains(searchText));
                        break;
                }

                dgvEmployees.DataSource = filteredList.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Qidiruvda xatolik: {ex.Message}", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void LoadAllEmployees()
        {
            try
            {
                var employeeList = _employeeService.GetEAll() as List<EmployeeResponseDTO>;
                dgvEmployees.DataSource = employeeList;





            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xodimlar yuklanmadi: {ex.Message}", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            this.Hide();
            var loginForm = new LoginForm(_adminService, _employeeService);
            loginForm.ShowDialog();
        }

        private void rootSearchAll_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = rootSearchAll.Text.Trim().ToLower();

                var employeeList = _employeeService.GetEAll() as List<EmployeeResponseDTO>;

                if (string.IsNullOrEmpty(searchText))
                {
                    dgvEmployees.DataSource = employeeList;
                    return;
                }

                var filteredList = employeeList.Where(e =>
                    (e.Fullname != null && e.Fullname.ToLower().Contains(searchText)) ||
                    (e.Position != null && e.Position.ToLower().Contains(searchText)) ||
                    (e.WorkAddress != null && e.WorkAddress.ToLower().Contains(searchText)) ||
                    (e.WorkPhone != null && e.WorkPhone.ToLower().Contains(searchText)) ||
                    (e.PersonalPhone != null && e.PersonalPhone.ToLower().Contains(searchText)) ||
                    (e.HomePhone != null && e.HomePhone.ToLower().Contains(searchText))
                ).ToList();

                dgvEmployees.DataSource = filteredList;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Umumiy qidiruvda xatolik: {ex.Message}", "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RootHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
