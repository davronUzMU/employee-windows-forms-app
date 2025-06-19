namespace EmployeeApp.Forms
{
    partial class EditEmployeeForm
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
            label1 = new Label();
            dashbortWay = new Button();
            label2 = new Label();
            txtFullName = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            editEmployee = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(dashbortWay);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(885, 100);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Franklin Gothic Demi", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(263, 30);
            label1.Name = "label1";
            label1.Size = new Size(333, 28);
            label1.TabIndex = 0;
            label1.Text = "Hodim ma'lumotlarini o'zgartirish";
            // 
            // dashbortWay
            // 
            dashbortWay.Font = new Font("Bahnschrift SemiBold", 12F);
            dashbortWay.ForeColor = Color.Blue;
            dashbortWay.Location = new Point(667, 30);
            dashbortWay.Name = "dashbortWay";
            dashbortWay.Size = new Size(165, 32);
            dashbortWay.TabIndex = 1;
            dashbortWay.Text = "Chiqish";
            dashbortWay.UseVisualStyleBackColor = true;
            dashbortWay.Click += dashbortWay_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("TruthCYR Bold", 18F);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(307, 136);
            label2.Name = "label2";
            label2.Size = new Size(271, 29);
            label2.TabIndex = 1;
            label2.Text = "Hodimni o'zgartirish";
            // 
            // txtFullName
            // 
            txtFullName.AutoSize = true;
            txtFullName.Font = new Font("Rockwell Extra Bold", 14F);
            txtFullName.ForeColor = Color.Navy;
            txtFullName.Location = new Point(30, 208);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(160, 22);
            txtFullName.TabIndex = 2;
            txtFullName.Text = "WorkAddress";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Rockwell Extra Bold", 14F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(30, 267);
            label3.Name = "label3";
            label3.Size = new Size(119, 22);
            label3.TabIndex = 3;
            label3.Text = "Fullname";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Rockwell Extra Bold", 14F);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(30, 322);
            label4.Name = "label4";
            label4.Size = new Size(106, 22);
            label4.TabIndex = 4;
            label4.Text = "Position";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Extra Bold", 14F);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(30, 377);
            label5.Name = "label5";
            label5.Size = new Size(142, 22);
            label5.TabIndex = 5;
            label5.Text = "WorkPhone";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Rockwell Extra Bold", 14F);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(30, 430);
            label6.Name = "label6";
            label6.Size = new Size(185, 22);
            label6.TabIndex = 6;
            label6.Text = "PersonalPhone";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Rockwell Extra Bold", 14F);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(30, 483);
            label7.Name = "label7";
            label7.Size = new Size(150, 22);
            label7.TabIndex = 7;
            label7.Text = "HomePhone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Rockwell Extra Bold", 14F);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(30, 549);
            label8.Name = "label8";
            label8.Size = new Size(63, 22);
            label8.TabIndex = 8;
            label8.Text = "Date";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 194);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(450, 30);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(273, 259);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(450, 30);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(273, 314);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(450, 30);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(273, 369);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(450, 30);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(273, 422);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(450, 30);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(273, 475);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(450, 30);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(273, 534);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(450, 23);
            dateTimePicker1.TabIndex = 15;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // editEmployee
            // 
            editEmployee.BackColor = Color.FromArgb(0, 0, 64);
            editEmployee.Font = new Font("Stencil", 14F);
            editEmployee.ForeColor = Color.White;
            editEmployee.Location = new Point(549, 592);
            editEmployee.Name = "editEmployee";
            editEmployee.Size = new Size(174, 41);
            editEmployee.TabIndex = 16;
            editEmployee.Text = "O'zgartirish";
            editEmployee.UseVisualStyleBackColor = false;
            editEmployee.Click += editEmployee_Click;
            // 
            // EditEmployeeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(885, 645);
            Controls.Add(editEmployee);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label2);
            Controls.Add(panel1);
            ForeColor = Color.FromArgb(0, 0, 192);
            Name = "EditEmployeeForm";
            Text = "EditEmployeeForm";
            Load += EditEmployeeForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button dashbortWay;
        private Label label1;
        private Label label2;
        private Label txtFullName;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private DateTimePicker dateTimePicker1;
        private Button editEmployee;
    }
}