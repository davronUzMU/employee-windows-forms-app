namespace EmployeeApp.Forms
{
    partial class DashbortForm
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
            employeeShow = new DataGridView();
            panel1 = new Panel();
            rootWay = new Button();
            txtLogOut = new Button();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            addEmployee = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)employeeShow).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // employeeShow
            // 
            employeeShow.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            employeeShow.Location = new Point(211, 131);
            employeeShow.Name = "employeeShow";
            employeeShow.Size = new Size(929, 453);
            employeeShow.TabIndex = 0;
            employeeShow.CellContentClick += employeeShow_CellContentClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(rootWay);
            panel1.Controls.Add(txtLogOut);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 131);
            panel1.TabIndex = 1;
            // 
            // rootWay
            // 
            rootWay.Font = new Font("Tw Cen MT Condensed Extra Bold", 12F);
            rootWay.ForeColor = Color.Blue;
            rootWay.Location = new Point(178, 45);
            rootWay.Name = "rootWay";
            rootWay.Size = new Size(112, 37);
            rootWay.TabIndex = 3;
            rootWay.Text = "Bosh sahifa";
            rootWay.UseVisualStyleBackColor = true;
            rootWay.Click += rootWay_Click;
            // 
            // txtLogOut
            // 
            txtLogOut.Font = new Font("Tahoma", 14F);
            txtLogOut.ForeColor = Color.Navy;
            txtLogOut.Location = new Point(934, 47);
            txtLogOut.Name = "txtLogOut";
            txtLogOut.Size = new Size(138, 41);
            txtLogOut.TabIndex = 2;
            txtLogOut.Text = "Chiqish";
            txtLogOut.UseVisualStyleBackColor = true;
            txtLogOut.Click += txtLogOut_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(386, 53);
            label2.Name = "label2";
            label2.Size = new Size(412, 29);
            label2.TabIndex = 1;
            label2.Text = "Hodimlar bilan ishlash bo'limi";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_administrator_male_94;
            pictureBox2.Location = new Point(23, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(93, 98);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Navy;
            panel2.Controls.Add(addEmployee);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 491);
            panel2.TabIndex = 2;
            // 
            // addEmployee
            // 
            addEmployee.Font = new Font("Stencil", 14F);
            addEmployee.ForeColor = Color.FromArgb(0, 0, 64);
            addEmployee.Location = new Point(54, 202);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(112, 38);
            addEmployee.TabIndex = 2;
            addEmployee.Text = "Qo'shish";
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += addEmployee_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(26, 157);
            label1.Name = "label1";
            label1.Size = new Size(160, 19);
            label1.TabIndex = 1;
            label1.Text = "Hodim qo'shish";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_employee_100;
            pictureBox1.Location = new Point(54, 38);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 102);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // DashbortForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 622);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(employeeShow);
            Name = "DashbortForm";
            Text = "DashbortForm";
            Load += DashbortForm_Load;
            ((System.ComponentModel.ISupportInitialize)employeeShow).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView employeeShow;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Button addEmployee;
        private Button txtLogOut;
        private Label label2;
        private PictureBox pictureBox2;
        private Button rootWay;
    }
}