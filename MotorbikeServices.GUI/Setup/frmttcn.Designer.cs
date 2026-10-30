namespace MotorbikeServices.GUI.Setup
{
    partial class frmttcn
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
            panel2 = new Panel();
            btnCapNhat = new Button();
            txtEmail = new TextBox();
            label6 = new Label();
            txtSDT = new TextBox();
            txtHoTen = new TextBox();
            label5 = new Label();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            label4 = new Label();
            dtpNgaySinh = new DateTimePicker();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.BlanchedAlmond;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(959, 115);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label1.ForeColor = Color.FromArgb(192, 192, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(959, 112);
            label1.TabIndex = 0;
            label1.Text = "Thông tin cá nhân";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Thistle;
            panel2.Controls.Add(btnCapNhat);
            panel2.Controls.Add(txtEmail);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtSDT);
            panel2.Controls.Add(txtHoTen);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(rdoNu);
            panel2.Controls.Add(rdoNam);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(dtpNgaySinh);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(959, 681);
            panel2.TabIndex = 1;
            // 
            // btnCapNhat
            // 
            btnCapNhat.Anchor = AnchorStyles.None;
            btnCapNhat.BackColor = Color.Red;
            btnCapNhat.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnCapNhat.ForeColor = Color.White;
            btnCapNhat.Location = new Point(240, 543);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(178, 63);
            btnCapNhat.TabIndex = 23;
            btnCapNhat.Text = "Cập Nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(243, 465);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(376, 27);
            txtEmail.TabIndex = 22;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label6.Location = new Point(35, 448);
            label6.Name = "label6";
            label6.Size = new Size(112, 46);
            label6.TabIndex = 21;
            label6.Text = "Email:";
            // 
            // txtSDT
            // 
            txtSDT.Anchor = AnchorStyles.None;
            txtSDT.Location = new Point(243, 374);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(376, 27);
            txtSDT.TabIndex = 20;
            // 
            // txtHoTen
            // 
            txtHoTen.Anchor = AnchorStyles.None;
            txtHoTen.Location = new Point(240, 81);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(376, 27);
            txtHoTen.TabIndex = 19;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label5.Location = new Point(35, 357);
            label5.Name = "label5";
            label5.Size = new Size(90, 46);
            label5.TabIndex = 17;
            label5.Text = "SĐT:";
            // 
            // rdoNu
            // 
            rdoNu.Anchor = AnchorStyles.None;
            rdoNu.AutoSize = true;
            rdoNu.Font = new Font("Segoe UI", 12F);
            rdoNu.Location = new Point(321, 281);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(60, 32);
            rdoNu.TabIndex = 16;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.Anchor = AnchorStyles.None;
            rdoNam.AutoSize = true;
            rdoNam.Checked = true;
            rdoNam.Font = new Font("Segoe UI", 12F);
            rdoNam.Location = new Point(240, 281);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 32);
            rdoNam.TabIndex = 15;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label4.Location = new Point(32, 270);
            label4.Name = "label4";
            label4.Size = new Size(168, 46);
            label4.TabIndex = 13;
            label4.Text = "Giới Tính:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Anchor = AnchorStyles.None;
            dtpNgaySinh.Location = new Point(240, 185);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 12;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label3.Location = new Point(32, 166);
            label3.Name = "label3";
            label3.Size = new Size(186, 46);
            label3.TabIndex = 11;
            label3.Text = "Ngày Sinh:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 625);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(959, 56);
            dataGridView1.TabIndex = 10;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold);
            label2.Location = new Point(32, 64);
            label2.Name = "label2";
            label2.Size = new Size(179, 46);
            label2.TabIndex = 0;
            label2.Text = "Họ và Tên:";
            // 
            // frmttcn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(959, 796);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmttcn";
            Text = "frmttcn";
            Load += frmttcn_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox txtSDT;
        private TextBox txtHoTen;
        private Label label5;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private Label label4;
        private DateTimePicker dtpNgaySinh;
        private Button btnCapNhat;
        private TextBox txtEmail;
        private Label label6;
    }
}