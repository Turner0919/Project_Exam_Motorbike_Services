
namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcHangXe
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel pnlToolbar;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvHangXe;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlMain = new Panel();
            lblTitle = new Label();
            lblDescription = new Label();
            pnlToolbar = new Panel();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvHangXe = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            pnlMain.SuspendLayout();
            pnlToolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangXe).BeginInit();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.FromArgb(245, 247, 250);
            pnlMain.Controls.Add(lblTitle);
            pnlMain.Controls.Add(lblDescription);
            pnlMain.Controls.Add(pnlToolbar);
            pnlMain.Controls.Add(dgvHangXe);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Padding = new Padding(12);
            pnlMain.Size = new Size(900, 600);
            pnlMain.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.Location = new Point(12, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(459, 46);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quản lý hãng xe và dòng xe";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 10F);
            lblDescription.ForeColor = Color.FromArgb(95, 112, 135);
            lblDescription.Location = new Point(20, 56);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(334, 23);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Quản lý thông tin hãng xe và các dòng xe.";
            // 
            // pnlToolbar
            // 
            pnlToolbar.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnlToolbar.BackColor = Color.FromArgb(245, 247, 250);
            pnlToolbar.Controls.Add(txtTimKiem);
            pnlToolbar.Controls.Add(btnThem);
            pnlToolbar.Controls.Add(btnSua);
            pnlToolbar.Controls.Add(btnXoa);
            pnlToolbar.Controls.Add(btnLamMoi);
            pnlToolbar.Location = new Point(12, 95);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(1550, 42);
            pnlToolbar.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F);
            txtTimKiem.Location = new Point(8, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên hãng xe để tìm...";
            txtTimKiem.Size = new Size(250, 30);
            txtTimKiem.TabIndex = 0;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(55, 126, 184);
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(265, 2);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(145, 36);
            btnThem.TabIndex = 1;
            btnThem.Text = "+ Thêm hãng xe";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.FromArgb(25, 45, 80);
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(420, 2);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(75, 36);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(180, 65, 65);
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(505, 2);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(75, 36);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.FromArgb(25, 45, 80);
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(590, 2);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(90, 36);
            btnLamMoi.TabIndex = 4;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // dgvHangXe
            // 
            dgvHangXe.AllowUserToAddRows = false;
            dgvHangXe.AllowUserToDeleteRows = false;
            dgvHangXe.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHangXe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHangXe.BackgroundColor = Color.White;
            dgvHangXe.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(25, 45, 80);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHangXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHangXe.ColumnHeadersHeight = 42;
            dgvHangXe.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3 });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(220, 235, 248);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(25, 45, 80);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvHangXe.DefaultCellStyle = dataGridViewCellStyle4;
            dgvHangXe.EnableHeadersVisualStyles = false;
            dgvHangXe.Location = new Point(12, 150);
            dgvHangXe.MultiSelect = false;
            dgvHangXe.Name = "dgvHangXe";
            dgvHangXe.ReadOnly = true;
            dgvHangXe.RowHeadersVisible = false;
            dgvHangXe.RowHeadersWidth = 51;
            dgvHangXe.RowTemplate.Height = 36;
            dgvHangXe.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHangXe.Size = new Size(1550, 900);
            dgvHangXe.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Mã hãng";
            dataGridViewTextBoxColumn1.MinimumWidth = 6;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Tên hãng xe";
            dataGridViewTextBoxColumn2.MinimumWidth = 6;
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Quốc gia";
            dataGridViewTextBoxColumn3.MinimumWidth = 6;
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // UcHangXe
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 250);
            Controls.Add(pnlMain);
            Name = "UcHangXe";
            Size = new Size(900, 600);
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHangXe).EndInit();
            ResumeLayout(false);
        }

        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
