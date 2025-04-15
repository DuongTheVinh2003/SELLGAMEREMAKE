namespace SELLGAMEREAMKE
{
    partial class TKeND
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
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            dataGridView1 = new DataGridView();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(22, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(266, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "User";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(446, 26);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(198, 27);
            textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(294, 59);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(494, 363);
            dataGridView1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(78, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(158, 37);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(78, 106);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(158, 37);
            textBox3.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 61);
            label1.Name = "label1";
            label1.Size = new Size(60, 31);
            label1.TabIndex = 6;
            label1.Text = "User";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 113);
            label2.Name = "label2";
            label2.Size = new Size(70, 25);
            label2.TabIndex = 7;
            label2.Text = "ID User";
            // 
            // button1
            // 
            button1.Location = new Point(25, 228);
            button1.Name = "button1";
            button1.Size = new Size(94, 39);
            button1.TabIndex = 8;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(125, 228);
            button2.Name = "button2";
            button2.Size = new Size(94, 39);
            button2.TabIndex = 9;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(125, 287);
            button3.Name = "button3";
            button3.Size = new Size(94, 39);
            button3.TabIndex = 10;
            button3.Text = "ReLoad";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(25, 287);
            button4.Name = "button4";
            button4.Size = new Size(94, 39);
            button4.TabIndex = 11;
            button4.Text = "Xóa";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(650, 24);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "Tìm kiếm";
            button5.UseVisualStyleBackColor = true;
            // 
            // TKeND
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Name = "TKeND";
            Text = "TKeND";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView1;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
    }
}