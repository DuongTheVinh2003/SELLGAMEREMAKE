namespace SELLGAMEREAMKE
{
    partial class CaNhan
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            label3 = new Label();
            panel4 = new Panel();
            panel3 = new Panel();
            panel5 = new Panel();
            btndel = new Button();
            btnedit = new Button();
            btnadd = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLight;
            pictureBox1.Location = new Point(32, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(136, 153);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(187, 96);
            label1.Name = "label1";
            label1.Size = new Size(139, 41);
            label1.TabIndex = 1;
            label1.Text = "Uername";
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(32, 226);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 184);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(746, 60);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 16);
            label2.Name = "label2";
            label2.Size = new Size(186, 26);
            label2.TabIndex = 0;
            label2.Text = "Hoạt động gần đây";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(32, 427);
            label3.Name = "label3";
            label3.Size = new Size(175, 31);
            label3.TabIndex = 3;
            label3.Text = "Sản phẩm đăng";
            // 
            // panel4
            // 
            panel4.BackColor = SystemColors.ActiveBorder;
            panel4.Location = new Point(558, 475);
            panel4.Name = "panel4";
            panel4.Size = new Size(197, 250);
            panel4.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.ActiveBorder;
            panel3.Location = new Point(308, 475);
            panel3.Name = "panel3";
            panel3.Size = new Size(197, 250);
            panel3.TabIndex = 5;
            // 
            // panel5
            // 
            panel5.BackColor = SystemColors.ActiveBorder;
            panel5.Location = new Point(58, 475);
            panel5.Name = "panel5";
            panel5.Size = new Size(197, 250);
            panel5.TabIndex = 4;
            // 
            // btndel
            // 
            btndel.Location = new Point(654, 427);
            btndel.Name = "btndel";
            btndel.Size = new Size(101, 31);
            btndel.TabIndex = 17;
            btndel.Text = "Xóa";
            btndel.UseVisualStyleBackColor = true;
            // 
            // btnedit
            // 
            btnedit.Location = new Point(508, 427);
            btnedit.Name = "btnedit";
            btnedit.Size = new Size(101, 31);
            btnedit.TabIndex = 16;
            btnedit.Text = "Sửa";
            btnedit.UseVisualStyleBackColor = true;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(342, 424);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(101, 31);
            btnadd.TabIndex = 15;
            btnadd.Text = "Thêm";
            btnadd.UseVisualStyleBackColor = true;
            // 
            // CaNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(873, 737);
            Controls.Add(btndel);
            Controls.Add(btnedit);
            Controls.Add(btnadd);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel5);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "CaNhan";
            Text = "CaNhan";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Panel panel3;
        private Panel panel5;
        private Button btndel;
        private Button btnedit;
        private Button btnadd;
    }
}