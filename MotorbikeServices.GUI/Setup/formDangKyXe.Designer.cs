namespace MotorbikeServices.GUI.Setup
{
    partial class formDangKyXe
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
            panel2 = new Panel();
            label1 = new Label();
            label5 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            txtChuXe = new TextBox();
            label7 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(974, 125);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(txtChuXe);
            panel2.Controls.Add(label7);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(974, 501);
            panel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(234, 42);
            label1.Name = "label1";
            label1.Size = new Size(494, 46);
            label1.TabIndex = 0;
            label1.Text = "Đăng ký xe mới/ Cập nhật xe cũ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F);
            label5.Location = new Point(112, 280);
            label5.Name = "label5";
            label5.Size = new Size(102, 32);
            label5.TabIndex = 16;
            label5.Text = "Hãng xe";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F);
            label3.Location = new Point(91, 190);
            label3.Name = "label3";
            label3.Size = new Size(123, 32);
            label3.TabIndex = 13;
            label3.Text = "Biển số xe";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(234, 190);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(183, 27);
            textBox2.TabIndex = 12;
            // 
            // txtChuXe
            // 
            txtChuXe.Location = new Point(234, 99);
            txtChuXe.Name = "txtChuXe";
            txtChuXe.Size = new Size(183, 27);
            txtChuXe.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F);
            label7.Location = new Point(50, 94);
            label7.Name = "label7";
            label7.Size = new Size(164, 32);
            label7.TabIndex = 10;
            label7.Text = "Họ tên chủ xe";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(234, 284);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(183, 28);
            comboBox1.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(50, 364);
            label2.Name = "label2";
            label2.Size = new Size(167, 32);
            label2.TabIndex = 19;
            label2.Text = "Năm sản xuất ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(234, 369);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(183, 27);
            textBox1.TabIndex = 18;
            // 
            // formDangKyXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 626);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "formDangKyXe";
            Text = "formDangKyXe";
            Load += formDangKyXe_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label5;
        private Label label3;
        private TextBox textBox2;
        private TextBox txtChuXe;
        private Label label7;
    }
}