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
    public partial class DashbortForm : Form
    {
        private readonly IEmployeeService _employeeService;
        private readonly IAdminService _adminService;
        private readonly int admin_id;

        public DashbortForm(IEmployeeService employeeService, IAdminService adminService, int admin_id)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _adminService = adminService;
            this.admin_id = admin_id;
        }

        public DashbortForm(IEmployeeService employeeService, IAdminService adminService)
        {
            InitializeComponent();
            _employeeService = employeeService;
            _adminService = adminService;
        }

        private void DashbortForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
        }

        private void LoadEmployees()
        {
            var employees = _employeeService.GetEAll() as List<EmployeeResponseDTO>;

            // DataGridView tozalash
            employeeShow.Columns.Clear();
            employeeShow.Rows.Clear();

            // Ustunlar qo‘shish
            employeeShow.Columns.Add("Id", "ID");
            employeeShow.Columns.Add("Fullname", "F.I.O");
            employeeShow.Columns.Add("Position", "Lavozimi");
            employeeShow.Columns.Add("WorkPhone", "Ish telefoni");
            employeeShow.Columns.Add("ServicePhone", "Xizmat telefoni");
            employeeShow.Columns.Add("HomePhone", "Uy telefoni");
            employeeShow.Columns.Add("BirthDate", "Tug‘ilgan sana");

            // Tugmalar uchun ustunlar
            var editButton = new DataGridViewButtonColumn
            {
                HeaderText = "Tahrirlash",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
                Name = "Edit"
            };
            employeeShow.Columns.Add(editButton);

            var deleteButton = new DataGridViewButtonColumn
            {
                HeaderText = "O‘chirish",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
                Name = "Delete"
            };
            employeeShow.Columns.Add(deleteButton);


            // Ma’lumotlarni qo‘shish
            foreach (var emp in employees)
            {
                employeeShow.Rows.Add(emp.Id, emp.Fullname, emp.Position, emp.WorkPhone, emp.PersonalPhone, emp.HomePhone, emp.DateOfBirth.ToShortDateString());
            }
        }

        private void employeeShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            int id = Convert.ToInt32(employeeShow.Rows[e.RowIndex].Cells["Id"].Value);

            if (employeeShow.Columns[e.ColumnIndex].Name == "Delete")
            {
                var confirm = MessageBox.Show("Aniq o‘chirmoqchimisiz?", "Tasdiqlash", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _employeeService.DeleteE(id);
                    LoadEmployees();
                }
            }
            else if (employeeShow.Columns[e.ColumnIndex].Name == "Edit")
            {
                var employee = (_employeeService.GetEAll() as List<EmployeeResponseDTO>)?.FirstOrDefault(x => x.Id == id);
                if (employee != null)
                {
                    int emp_id = employee.Id;
                    var editForm = new EditEmployeeForm(_employeeService,_adminService,emp_id);
                    editForm.ShowDialog();
                    LoadEmployees();
                }
            }
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployeeForm addEmployeeForm = new AddEmployeeForm(_employeeService, _adminService);
            addEmployeeForm.ShowDialog();
        }

        private void txtLogOut_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Tizimdan chiqmoqchimisiz?", "Chiqish", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _adminService.DeleteA(admin_id); // aynan tizimga kirgan adminni o‘chiramiz

                    this.Hide();
                    var rootForm = new RootForm(_employeeService, _adminService);
                    rootForm.Show();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xatolik yuz berdi: " + ex.Message, "Xatolik", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rootWay_Click(object sender, EventArgs e)
        {
            this.Hide();
            RootForm rootForm = new RootForm(_employeeService, _adminService);
            rootForm.Show();
        }
    }
}
