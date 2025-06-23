namespace EmployeeApp.Forms
{
    partial class AddEmployeeForm
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
            panel1 = new Panel();
            label6 = new Label();
            txtFullName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dateTimePicker1 = new DateTimePicker();
            workAddress = new TextBox();
            fullName = new TextBox();
            position = new TextBox();
            workPhone = new TextBox();
            personalPhone = new TextBox();
            homePhone = new TextBox();
            label7 = new Label();
            label8 = new Label();
            btnAdd = new Button();
            dashbortWay = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(dashbortWay);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(921, 100);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell Extra Bold", 18F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(346, 35);
            label6.Name = "label6";
            label6.Size = new Size(237, 28);
            label6.TabIndex = 0;
            label6.Text = "Hodim qo'shish";
            // 
            // txtFullName
            // 
            txtFullName.AutoSize = true;
            txtFullName.Font = new Font("Rockwell Extra Bold", 14F);
            txtFullName.ForeColor = Color.Navy;
            txtFullName.Location = new Point(12, 174);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(160, 22);
            txtFullName.TabIndex = 1;
            txtFullName.Text = "WorkAddress";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Extra Bold", 14F);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(12, 236);
            label1.Name = "label1";
            label1.Size = new Size(119, 22);
            label1.TabIndex = 2;
            label1.Text = "Fullname";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Rockwell Extra Bold", 14F);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(12, 302);
            label2.Name = "label2";
            label2.Size = new Size(106, 22);
            label2.TabIndex = 3;
            label2.Text = "Position";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell Extra Bold", 14F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(12, 367);
            label3.Name = "label3";
            label3.Size = new Size(142, 22);
            label3.TabIndex = 4;
            label3.Text = "WorkPhone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell Extra Bold", 14F);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(12, 429);
            label4.Name = "label4";
            label4.Size = new Size(185, 22);
            label4.TabIndex = 5;
            label4.Text = "PersonalPhone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Extra Bold", 14F);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(12, 488);
            label5.Name = "label5";
            label5.Size = new Size(150, 22);
            label5.TabIndex = 6;
            label5.Text = "HomePhone";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = Color.Navy;
            dateTimePicker1.CalendarMonthBackground = Color.Navy;
            dateTimePicker1.Location = new Point(279, 560);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(408, 23);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // workAddress
            // 
            workAddress.Location = new Point(279, 163);
            workAddress.Multiline = true;
            workAddress.Name = "workAddress";
            workAddress.Size = new Size(408, 26);
            workAddress.TabIndex = 8;
            workAddress.TextChanged += workAddress_TextChanged;
            // 
            // fullName
            // 
            fullName.Location = new Point(279, 239);
            fullName.Multiline = true;
            fullName.Name = "fullName";
            fullName.Size = new Size(408, 26);
            fullName.TabIndex = 9;
            fullName.TextChanged += fullName_TextChanged;
            // 
            // position
            // 
            position.Location = new Point(279, 302);
            position.Multiline = true;
            position.Name = "position";
            position.Size = new Size(408, 26);
            position.TabIndex = 10;
            position.TextChanged += position_TextChanged;
            // 
            // workPhone
            // 
            workPhone.Location = new Point(279, 370);
            workPhone.Multiline = true;
            workPhone.Name = "workPhone";
            workPhone.Size = new Size(408, 26);
            workPhone.TabIndex = 11;
            workPhone.TextChanged += workPhone_TextChanged;
            // 
            // personalPhone
            // 
            personalPhone.Location = new Point(279, 432);
            personalPhone.Multiline = true;
            personalPhone.Name = "personalPhone";
            personalPhone.Size = new Size(408, 26);
            personalPhone.TabIndex = 12;
            personalPhone.TextChanged += personalPhone_TextChanged;
            // 
            // homePhone
            // 
            homePhone.Location = new Point(279, 484);
            homePhone.Multiline = true;
            homePhone.Name = "homePhone";
            homePhone.Size = new Size(408, 26);
            homePhone.TabIndex = 13;
            homePhone.TextChanged += homePhone_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell Extra Bold", 14F);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(22, 560);
            label7.Name = "label7";
            label7.Size = new Size(0, 22);
            label7.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell Extra Bold", 14F);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(12, 560);
            label8.Name = "label8";
            label8.Size = new Size(146, 22);
            label8.TabIndex = 15;
            label8.Text = "DateOfBirth";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Rockwell Extra Bold", 16F);
            btnAdd.ForeColor = Color.FromArgb(0, 0, 64);
            btnAdd.Location = new Point(315, 642);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 39);
            btnAdd.TabIndex = 16;
            btnAdd.Text = "Qo'shish";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // dashbortWay
            // 
            dashbortWay.Font = new Font("TruthCYR Bold", 14F);
            dashbortWay.ForeColor = Color.Navy;
            dashbortWay.Location = new Point(717, 35);
            dashbortWay.Name = "dashbortWay";
            dashbortWay.Size = new Size(148, 38);
            dashbortWay.TabIndex = 1;
            dashbortWay.Text = "Chiqish";
            dashbortWay.UseVisualStyleBackColor = true;
            dashbortWay.Click += dashbortWay_Click;
            // 
            // AddEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(921, 693);
            Controls.Add(btnAdd);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(homePhone);
            Controls.Add(personalPhone);
            Controls.Add(workPhone);
            Controls.Add(position);
            Controls.Add(fullName);
            Controls.Add(workAddress);
            Controls.Add(dateTimePicker1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFullName);
            Controls.Add(panel1);
            Name = "AddEmployeeForm";
            Text = "AddEmployeeForm";
            Load += AddEmployeeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label txtFullName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker1;
        private TextBox workAddress;
        private TextBox fullName;
        private TextBox position;
        private TextBox workPhone;
        private TextBox personalPhone;
        private TextBox homePhone;
        private Label label7;
        private Label label8;
        private Button btnAdd;
        private Button dashbortWay;
    }
}