namespace MotorbikeServices.GUI.Setup
{
    partial class frmaccountuser
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            button4 = new Button();
            button3 = new Button();
            btn1 = new Button();
            button2 = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.8779335F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.12206F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(852, 525);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btn1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(223, 519);
            panel1.TabIndex = 0;
            // 
            // button4
            // 
            button4.Location = new Point(-3, 263);
            button4.Name = "button4";
            button4.Size = new Size(229, 63);
            button4.TabIndex = 4;
            button4.Text = "  Chi phí dự kiến và tổng";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(-6, 194);
            button3.Name = "button3";
            button3.Size = new Size(229, 63);
            button3.TabIndex = 3;
            button3.Text = "   Lịch sử bảo dưỡng";
            button3.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            btn1.Location = new Point(-3, 56);
            btn1.Name = "btn1";
            btn1.Size = new Size(229, 63);
            btn1.TabIndex = 1;
            btn1.Text = "Thông tin cá nhân";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(-6, 125);
            button2.Name = "button2";
            button2.Size = new Size(229, 63);
            button2.TabIndex = 2;
            button2.Text = "    Lịch bảo dưỡng ";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.Location = new Point(0, -3);
            label1.Name = "label1";
            label1.Size = new Size(223, 30);
            label1.TabIndex = 0;
            label1.Text = "Thông tin người dùng";
            label1.Click += label1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(232, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(617, 519);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // frmaccountuser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 525);
            Controls.Add(tableLayoutPanel1);
            Name = "frmaccountuser";
            Text = "frmaccountuser";
            WindowState = FormWindowState.Maximized;
            Load += frmaccountuser_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button button4;
        private Button button3;
        private Button btn1;
        private Button button2;
        private Label label1;
    }
}