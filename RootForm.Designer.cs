namespace EmployeeApp
{
    partial class RootForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RootForm));
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            RootHeader = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            login = new Button();
            panel1 = new Panel();
            label2 = new Label();
            cmbFilter = new ComboBox();
            panel2 = new Panel();
            rootSearchAll = new TextBox();
            label3 = new Label();
            btnSearch = new Button();
            txtSearch = new TextBox();
            dgvEmployees = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            fullnameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            positionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            workPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personalPhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            homePhoneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateOfBirthDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            employeeResponseDTOBindingSource = new BindingSource(components);
            RootHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).BeginInit();
            ((System.ComponentModel.ISupportInitialize)employeeResponseDTOBindingSource).BeginInit();
            SuspendLayout();
            // 
            // RootHeader
            // 
            RootHeader.BackColor = Color.FromArgb(17, 45, 78);
            RootHeader.BorderStyle = BorderStyle.Fixed3D;
            RootHeader.Controls.Add(pictureBox1);
            RootHeader.Controls.Add(label1);
            RootHeader.Controls.Add(login);
            RootHeader.Dock = DockStyle.Top;
            RootHeader.Location = new Point(0, 0);
            RootHeader.Name = "RootHeader";
            RootHeader.Size = new Size(1151, 108);
            RootHeader.TabIndex = 0;
            RootHeader.Paint += RootHeader_Paint;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(25, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 77);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(379, 31);
            label1.Name = "label1";
            label1.Size = new Size(404, 38);
            label1.TabIndex = 1;
            label1.Text = "Hodimlar haqida ma'lumot";
            // 
            // login
            // 
            login.Font = new Font("Arial Black", 10F);
            login.ForeColor = Color.FromArgb(0, 0, 64);
            login.Location = new Point(954, 31);
            login.Name = "login";
            login.Size = new Size(97, 38);
            login.TabIndex = 0;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(63, 114, 175);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(cmbFilter);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 108);
            panel1.Name = "panel1";
            panel1.Size = new Size(1151, 81);
            panel1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tw Cen MT Condensed Extra Bold", 14F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(289, 28);
            label2.Name = "label2";
            label2.Size = new Size(83, 22);
            label2.TabIndex = 1;
            label2.Text = "Tartiblash";
            // 
            // cmbFilter
            // 
            cmbFilter.Font = new Font("Arial Rounded MT Bold", 10F);
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(430, 30);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(272, 23);
            cmbFilter.TabIndex = 0;
            cmbFilter.SelectedIndexChanged += cmbFilter_SelectedIndexChanged;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(219, 226, 239);
            panel2.Controls.Add(rootSearchAll);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtSearch);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 189);
            panel2.Name = "panel2";
            panel2.Size = new Size(1151, 75);
            panel2.TabIndex = 2;
            // 
            // rootSearchAll
            // 
            rootSearchAll.BackColor = Color.FromArgb(62, 88, 121);
            rootSearchAll.BorderStyle = BorderStyle.FixedSingle;
            rootSearchAll.Location = new Point(181, 20);
            rootSearchAll.Multiline = true;
            rootSearchAll.Name = "rootSearchAll";
            rootSearchAll.Size = new Size(309, 29);
            rootSearchAll.TabIndex = 3;
            rootSearchAll.TextChanged += rootSearchAll_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F);
            label3.ForeColor = Color.FromArgb(0, 0, 64);
            label3.Location = new Point(12, 20);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 2;
            label3.Text = "Umumiy qidiruv";
            // 
            // btnSearch
            // 
            btnSearch.Font = new Font("Arial Black", 10F);
            btnSearch.ForeColor = Color.FromArgb(0, 0, 64);
            btnSearch.Location = new Point(1051, 17);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(88, 37);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Qidirish";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(62, 88, 121);
            txtSearch.Location = new Point(828, 23);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(203, 31);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dgvEmployees
            // 
            dgvEmployees.AutoGenerateColumns = false;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Arial Black", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgvEmployees.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgvEmployees.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployees.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, workAddressDataGridViewTextBoxColumn, fullnameDataGridViewTextBoxColumn, positionDataGridViewTextBoxColumn, workPhoneDataGridViewTextBoxColumn, personalPhoneDataGridViewTextBoxColumn, homePhoneDataGridViewTextBoxColumn, dateOfBirthDataGridViewTextBoxColumn });
            dgvEmployees.DataSource = employeeResponseDTOBindingSource;
            dgvEmployees.Location = new Point(39, 279);
            dgvEmployees.Name = "dgvEmployees";
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Control;
            dataGridViewCellStyle5.Font = new Font("Times New Roman", 10F);
            dataGridViewCellStyle5.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvEmployees.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            dataGridViewCellStyle6.ForeColor = Color.Black;
            dgvEmployees.RowsDefaultCellStyle = dataGridViewCellStyle6;
            dgvEmployees.Size = new Size(1062, 390);
            dgvEmployees.TabIndex = 3;
            dgvEmployees.CellContentClick += dgvEmployees_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // workAddressDataGridViewTextBoxColumn
            // 
            workAddressDataGridViewTextBoxColumn.DataPropertyName = "WorkAddress";
            workAddressDataGridViewTextBoxColumn.HeaderText = "WorkAddress";
            workAddressDataGridViewTextBoxColumn.Name = "workAddressDataGridViewTextBoxColumn";
            workAddressDataGridViewTextBoxColumn.Width = 175;
            // 
            // fullnameDataGridViewTextBoxColumn
            // 
            fullnameDataGridViewTextBoxColumn.DataPropertyName = "Fullname";
            fullnameDataGridViewTextBoxColumn.HeaderText = "Fullname";
            fullnameDataGridViewTextBoxColumn.Name = "fullnameDataGridViewTextBoxColumn";
            fullnameDataGridViewTextBoxColumn.Width = 135;
            // 
            // positionDataGridViewTextBoxColumn
            // 
            positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            positionDataGridViewTextBoxColumn.HeaderText = "Position";
            positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            positionDataGridViewTextBoxColumn.Width = 135;
            // 
            // workPhoneDataGridViewTextBoxColumn
            // 
            workPhoneDataGridViewTextBoxColumn.DataPropertyName = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.HeaderText = "WorkPhone";
            workPhoneDataGridViewTextBoxColumn.Name = "workPhoneDataGridViewTextBoxColumn";
            workPhoneDataGridViewTextBoxColumn.Width = 115;
            // 
            // personalPhoneDataGridViewTextBoxColumn
            // 
            personalPhoneDataGridViewTextBoxColumn.DataPropertyName = "PersonalPhone";
            personalPhoneDataGridViewTextBoxColumn.HeaderText = "PersonalPhone";
            personalPhoneDataGridViewTextBoxColumn.Name = "personalPhoneDataGridViewTextBoxColumn";
            personalPhoneDataGridViewTextBoxColumn.Width = 125;
            // 
            // homePhoneDataGridViewTextBoxColumn
            // 
            homePhoneDataGridViewTextBoxColumn.DataPropertyName = "HomePhone";
            homePhoneDataGridViewTextBoxColumn.HeaderText = "HomePhone";
            homePhoneDataGridViewTextBoxColumn.Name = "homePhoneDataGridViewTextBoxColumn";
            homePhoneDataGridViewTextBoxColumn.Width = 115;
            // 
            // dateOfBirthDataGridViewTextBoxColumn
            // 
            dateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth";
            dateOfBirthDataGridViewTextBoxColumn.Name = "dateOfBirthDataGridViewTextBoxColumn";
            dateOfBirthDataGridViewTextBoxColumn.Width = 120;
            // 
            // employeeResponseDTOBindingSource
            // 
            employeeResponseDTOBindingSource.DataSource = typeof(Payloads.EmployeeResponseDTO);
            // 
            // RootForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1151, 737);
            Controls.Add(dgvEmployees);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(RootHeader);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "RootForm";
            Text = "RootForm";
            Load += RootForm_Load;
            RootHeader.ResumeLayout(false);
            RootHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployees).EndInit();
            ((System.ComponentModel.ISupportInitialize)employeeResponseDTOBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel RootHeader;
        private Panel panel1;
        private ComboBox cmbFilter;
        private Panel panel2;
        private Button btnSearch;
        private TextBox txtSearch;
        private DataGridView dgvEmployees;
        private BindingSource employeeResponseDTOBindingSource;
        private Button login;
        private Label label1;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn fullnameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn workPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personalPhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn homePhoneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateOfBirthDataGridViewTextBoxColumn;
        private Label label2;
        private Label label3;
        private TextBox rootSearchAll;
        private PictureBox pictureBox1;
    }
}