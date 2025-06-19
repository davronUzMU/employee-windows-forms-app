namespace EmployeeApp.Forms
{
    partial class LoginForm
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
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 0, 64);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(332, 508);
            panel1.TabIndex = 0;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(477, 179);
            txtFullname.Multiline = true;
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(239, 34);
            txtFullname.TabIndex = 1;
            txtFullname.TextChanged += txtFullname_TextChanged;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(481, 270);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(204, 34);
            txtUsername.TabIndex = 2;
            txtUsername.TextChanged += txtUsername_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(477, 368);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(203, 34);
            txtPassword.TabIndex = 3;
            txtPassword.TextChanged += txtPassword_TextChanged;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Rockwell Extra Bold", 12F);
            btnLogin.ForeColor = Color.Blue;
            btnLogin.Location = new Point(527, 440);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(121, 47);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Kirish";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 18F);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(515, 88);
            label1.Name = "label1";
            label1.Size = new Size(82, 29);
            label1.TabIndex = 5;
            label1.Text = "Login";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 18F);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(336, 184);
            label2.Name = "label2";
            label2.Size = new Size(68, 29);
            label2.TabIndex = 6;
            label2.Text = "F.I.O";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 18F);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(338, 275);
            label3.Name = "label3";
            label3.Size = new Size(137, 29);
            label3.TabIndex = 7;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 18F);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(336, 373);
            label4.Name = "label4";
            label4.Size = new Size(137, 29);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Rockwell Extra Bold", 18F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 404);
            label5.Name = "label5";
            label5.Size = new Size(261, 28);
            label5.TabIndex = 0;
            label5.Text = "Ro'yxatdan o'tish";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_admin_settings_male_100;
            pictureBox1.Location = new Point(101, 179);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(112, 97);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(754, 508);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(txtFullname);
            Controls.Add(panel1);
            Name = "LoginForm";
            Text = "LoginForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label5;
    }
}