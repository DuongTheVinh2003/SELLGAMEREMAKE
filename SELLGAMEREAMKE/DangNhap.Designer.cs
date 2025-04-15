namespace SELLGAMEREAMKE
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btndnhap = new Button();
            btndky = new Button();
            btnthoat = new Button();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 68);
            label1.Name = "label1";
            label1.Size = new Size(210, 38);
            label1.TabIndex = 0;
            label1.Text = "SELLGAME";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(159, 135);
            label2.Name = "label2";
            label2.Size = new Size(61, 31);
            label2.TabIndex = 1;
            label2.Text = "User";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 216);
            label3.Name = "label3";
            label3.Size = new Size(112, 31);
            label3.TabIndex = 2;
            label3.Text = "Password";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(255, 140);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(296, 27);
            txtUser.TabIndex = 3;
            txtUser.TextChanged += textBox1_TextChanged;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(255, 221);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(296, 27);
            txtPassword.TabIndex = 4;
            // 
            // btndnhap
            // 
            btndnhap.Location = new Point(91, 327);
            btndnhap.Name = "btndnhap";
            btndnhap.Size = new Size(129, 49);
            btndnhap.TabIndex = 5;
            btndnhap.Text = "Đăng Nhập";
            btndnhap.UseVisualStyleBackColor = true;
            btndnhap.Click += btndnhap_Click;
            // 
            // btndky
            // 
            btndky.Location = new Point(328, 327);
            btndky.Name = "btndky";
            btndky.Size = new Size(129, 49);
            btndky.TabIndex = 6;
            btndky.Text = "Đăng Ký";
            btndky.UseVisualStyleBackColor = true;
            // 
            // btnthoat
            // 
            btnthoat.Location = new Point(556, 327);
            btnthoat.Name = "btnthoat";
            btnthoat.Size = new Size(129, 49);
            btnthoat.TabIndex = 7;
            btnthoat.Text = "Thoát";
            btnthoat.UseVisualStyleBackColor = true;
            btnthoat.Click += btnthoat_Click;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(573, 227);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(18, 17);
            chkShowPassword.TabIndex = 8;
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(chkShowPassword);
            Controls.Add(btnthoat);
            Controls.Add(btndky);
            Controls.Add(btndnhap);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btndnhap;
        private Button btndky;
        private Button btnthoat;
        private CheckBox chkShowPassword;
    }
}