namespace SELLGAMEREAMKE
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            btnDangXuat = new Button();
            label4 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            panel4 = new Panel();
            btnTKeSP = new Button();
            btnTKeND = new Button();
            panel3 = new Panel();
            btnCaNhan = new Button();
            btnThuVien = new Button();
            btnTrangChu = new Button();
            panelChildForm = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnDangXuat);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1902, 98);
            panel1.TabIndex = 0;
            panel1.Visible = false;
            // 
            // btnDangXuat
            // 
            btnDangXuat.Location = new Point(1812, 10);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(78, 71);
            btnDangXuat.TabIndex = 2;
            btnDangXuat.Text = "Đăng Xuất";
            btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(1605, 34);
            label4.Name = "label4";
            label4.Size = new Size(134, 22);
            label4.TabIndex = 1;
            label4.Text = "Tên người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 21);
            label2.Name = "label2";
            label2.Size = new Size(233, 38);
            label2.TabIndex = 0;
            label2.Text = "SELLLGAME";
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ButtonFace;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 98);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 935);
            panel2.TabIndex = 1;
            panel2.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 313);
            label1.Name = "label1";
            label1.Size = new Size(105, 25);
            label1.TabIndex = 2;
            label1.Text = "Thống kê";
            label1.Click += label1_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnTKeSP);
            panel4.Controls.Add(btnTKeND);
            panel4.Location = new Point(0, 341);
            panel4.Name = "panel4";
            panel4.Size = new Size(250, 151);
            panel4.TabIndex = 1;
            panel4.Visible = false;
            // 
            // btnTKeSP
            // 
            btnTKeSP.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTKeSP.Location = new Point(0, 74);
            btnTKeSP.Name = "btnTKeSP";
            btnTKeSP.Size = new Size(250, 74);
            btnTKeSP.TabIndex = 2;
            btnTKeSP.Text = "Thống kê sản phẩm";
            btnTKeSP.UseVisualStyleBackColor = true;
            btnTKeSP.Click += btnTKeSP_Click;
            // 
            // btnTKeND
            // 
            btnTKeND.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTKeND.Location = new Point(0, 0);
            btnTKeND.Name = "btnTKeND";
            btnTKeND.Size = new Size(250, 74);
            btnTKeND.TabIndex = 1;
            btnTKeND.Text = "Thống kê người dùng";
            btnTKeND.UseVisualStyleBackColor = true;
            btnTKeND.Click += btnTKeND_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnCaNhan);
            panel3.Controls.Add(btnThuVien);
            panel3.Controls.Add(btnTrangChu);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(250, 214);
            panel3.TabIndex = 0;
            panel3.Visible = false;
            // 
            // btnCaNhan
            // 
            btnCaNhan.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCaNhan.Location = new Point(0, 138);
            btnCaNhan.Name = "btnCaNhan";
            btnCaNhan.Size = new Size(250, 75);
            btnCaNhan.TabIndex = 2;
            btnCaNhan.Text = "Cá Nhân";
            btnCaNhan.UseVisualStyleBackColor = true;
            btnCaNhan.Click += btnCaNhan_Click;
            // 
            // btnThuVien
            // 
            btnThuVien.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThuVien.Location = new Point(0, 73);
            btnThuVien.Name = "btnThuVien";
            btnThuVien.Size = new Size(250, 67);
            btnThuVien.TabIndex = 1;
            btnThuVien.Text = "Thư Viện";
            btnThuVien.UseVisualStyleBackColor = true;
            btnThuVien.Click += btnThuVien_Click;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTrangChu.Location = new Point(0, 3);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(250, 74);
            btnTrangChu.TabIndex = 0;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            btnTrangChu.Click += btnTrangChu_Click;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = SystemColors.ActiveBorder;
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 98);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(1652, 935);
            panelChildForm.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelChildForm);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "MainForm";
            Text = "Mainform";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Panel panel3;
        private Button btnTrangChu;
        private Button btnCaNhan;
        private Button btnThuVien;
        private Panel panelChildForm;
        private Button btnTKeSP;
        private Button btnTKeND;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button btnDangXuat;
    }
}
