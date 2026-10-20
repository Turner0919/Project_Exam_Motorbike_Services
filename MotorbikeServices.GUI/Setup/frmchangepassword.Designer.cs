namespace MotorbikeServices.GUI.SETUP
{
    partial class frmchangepassword
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel1 = new Panel();
            panel3 = new Panel();
            btnXacNhanDatLai = new Button();
            txtXacNhanMatKhau1 = new TextBox();
            txtDatLaiMatKhau = new TextBox();
            label5 = new Label();
            label4 = new Label();
            btnXacNhan = new Button();
            txtDapAn = new TextBox();
            label3 = new Label();
            lblCauHoi = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.ActiveCaption;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(114, 444);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnXacNhan);
            panel1.Controls.Add(txtDapAn);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblCauHoi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(123, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(554, 444);
            panel1.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.PapayaWhip;
            panel3.Controls.Add(btnXacNhanDatLai);
            panel3.Controls.Add(txtXacNhanMatKhau1);
            panel3.Controls.Add(txtDatLaiMatKhau);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 201);
            panel3.Name = "panel3";
            panel3.Size = new Size(554, 243);
            panel3.TabIndex = 8;
            // 
            // btnXacNhanDatLai
            // 
            btnXacNhanDatLai.BackColor = Color.Yellow;
            btnXacNhanDatLai.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXacNhanDatLai.ForeColor = Color.Red;
            btnXacNhanDatLai.Location = new Point(195, 149);
            btnXacNhanDatLai.Name = "btnXacNhanDatLai";
            btnXacNhanDatLai.Size = new Size(172, 49);
            btnXacNhanDatLai.TabIndex = 9;
            btnXacNhanDatLai.Text = "Xác Nhận Đặt Lại";
            btnXacNhanDatLai.UseVisualStyleBackColor = false;
            btnXacNhanDatLai.Click += btnXacNhanDatLai_Click;
            // 
            // txtXacNhanMatKhau1
            // 
            txtXacNhanMatKhau1.Location = new Point(195, 102);
            txtXacNhanMatKhau1.Name = "txtXacNhanMatKhau1";
            txtXacNhanMatKhau1.Size = new Size(300, 27);
            txtXacNhanMatKhau1.TabIndex = 11;
            // 
            // txtDatLaiMatKhau
            // 
            txtDatLaiMatKhau.Location = new Point(195, 54);
            txtDatLaiMatKhau.Name = "txtDatLaiMatKhau";
            txtDatLaiMatKhau.Size = new Size(300, 27);
            txtDatLaiMatKhau.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label5.Location = new Point(18, 104);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 10;
            label5.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label4.Location = new Point(18, 56);
            label4.Name = "label4";
            label4.Size = new Size(150, 25);
            label4.TabIndex = 9;
            label4.Text = "Đặt Lại Mật Khẩu:";
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Gold;
            btnXacNhan.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnXacNhan.Location = new Point(273, 143);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(137, 40);
            btnXacNhan.TabIndex = 7;
            btnXacNhan.Text = "Xác Nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txtDapAn
            // 
            txtDapAn.Location = new Point(18, 151);
            txtDapAn.Name = "txtDapAn";
            txtDapAn.Size = new Size(219, 27);
            txtDapAn.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label3.Location = new Point(18, 123);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 5;
            label3.Text = "Đáp Án:";
            // 
            // lblCauHoi
            // 
            lblCauHoi.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold | FontStyle.Italic);
            lblCauHoi.Location = new Point(3, 98);
            lblCauHoi.Name = "lblCauHoi";
            lblCauHoi.Size = new Size(548, 25);
            lblCauHoi.TabIndex = 4;
            lblCauHoi.Text = "lblCauHoi";
            lblCauHoi.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(18, 73);
            label2.Name = "label2";
            label2.Size = new Size(134, 25);
            label2.TabIndex = 3;
            label2.Text = "Câu Hỏi Trả Lời:";
            // 
            // label1
            // 
            label1.BackColor = Color.Firebrick;
            label1.Font = new Font("Segoe UI Black", 16.8F, FontStyle.Bold);
            label1.ForeColor = Color.Snow;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(548, 56);
            label1.TabIndex = 1;
            label1.Text = "ĐẶT LẠI MẬT KHẨU";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ActiveCaption;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(683, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(114, 444);
            panel2.TabIndex = 2;
            // 
            // frmchangepassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "frmchangepassword";
            StartPosition = FormStartPosition.CenterParent;
            Text = "frmchangepassword";
            Load += frmchangepassword_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Label lblCauHoi;
        private Button btnXacNhan;
        private TextBox txtDapAn;
        private Label label3;
        private Panel panel3;
        private TextBox txtDatLaiMatKhau;
        private Label label5;
        private Label label4;
        private Button btnXacNhanDatLai;
        private TextBox txtXacNhanMatKhau1;
    }
}