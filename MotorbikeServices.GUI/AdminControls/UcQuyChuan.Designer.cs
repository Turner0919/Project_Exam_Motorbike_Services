namespace MotorbikeServices.GUI.AdminControls
{
    partial class UcQuyChuan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblDescription = new Label();
            pnlToolbar = new Panel();
            txtTimKiem = new TextBox();
            btnThem = new Button();
            pnlGrid = new Panel();
            pnlMainNew = new Panel();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dgvQuyChuan = new DataGridView();
            pnlToolbar.SuspendLayout();
            pnlGrid.SuspendLayout();
            pnlMainNew.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuyChuan).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(25, 45, 80);
            lblTitle.Location = new Point(20, 15);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(331, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Quy chuẩn bảo dưỡng";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDescription.ForeColor = Color.FromArgb(102, 112, 133);
            lblDescription.Location = new Point(25, 58);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(380, 23);
            lblDescription.TabIndex = 1;
            lblDescription.Text = "Quản lý quy chuẩn, số km và chi phí bảo dưỡng";
            // 
            // pnlToolbar
            // 
            pnlToolbar.BackColor = Color.Transparent;
            pnlToolbar.Controls.Add(btnLamMoi);
            pnlToolbar.Controls.Add(btnXoa);
            pnlToolbar.Controls.Add(btnSua);
            pnlToolbar.Controls.Add(txtTimKiem);
            pnlToolbar.Controls.Add(btnThem);
            pnlToolbar.Location = new Point(20, 95);
            pnlToolbar.Name = "pnlToolbar";
            pnlToolbar.Size = new Size(776, 114);
            pnlToolbar.TabIndex = 2;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(0, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PlaceholderText = "Nhập tên quy chuẩn...";
            txtTimKiem.Size = new Size(352, 30);
            txtTimKiem.TabIndex = 3;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.Cursor = Cursors.Hand;
            btnThem.FlatAppearance.BorderSize = 0;
            btnThem.FlatStyle = FlatStyle.Flat;
            btnThem.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = Color.FromArgb(25, 45, 80);
            btnThem.Location = new Point(380, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(90, 38);
            btnThem.TabIndex = 4;
            btnThem.Text = "+ Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvQuyChuan);
            pnlGrid.Location = new Point(23, 252);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Size = new Size(776, 245);
            pnlGrid.TabIndex = 6;
            // 
            // pnlMainNew
            // 
            pnlMainNew.BackColor = Color.FromArgb(245, 247, 251);
            pnlMainNew.Controls.Add(lblTitle);
            pnlMainNew.Controls.Add(lblDescription);
            pnlMainNew.Controls.Add(pnlToolbar);
            pnlMainNew.Controls.Add(pnlGrid);
            pnlMainNew.Dock = DockStyle.Fill;
            pnlMainNew.Location = new Point(0, 0);
            pnlMainNew.Name = "pnlMainNew";
            pnlMainNew.Size = new Size(816, 517);
            pnlMainNew.TabIndex = 0;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DeepSkyBlue;
            btnSua.Cursor = Cursors.Hand;
            btnSua.FlatAppearance.BorderColor = Color.FromArgb(210, 218, 228);
            btnSua.FlatAppearance.BorderSize = 2;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = Color.FromArgb(25, 45, 80);
            btnSua.Location = new Point(478, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(80, 38);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.FlatAppearance.BorderColor = Color.FromArgb(230, 210, 210);
            btnXoa.FlatAppearance.BorderSize = 2;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = Color.FromArgb(25, 45, 80);
            btnXoa.Location = new Point(566, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(80, 38);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.BackColor = Color.Silver;
            btnLamMoi.Cursor = Cursors.Hand;
            btnLamMoi.FlatAppearance.BorderColor = Color.FromArgb(230, 210, 210);
            btnLamMoi.FlatAppearance.BorderSize = 2;
            btnLamMoi.FlatStyle = FlatStyle.Flat;
            btnLamMoi.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLamMoi.ForeColor = Color.FromArgb(25, 45, 80);
            btnLamMoi.Location = new Point(654, 3);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(122, 38);
            btnLamMoi.TabIndex = 7;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = false;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dgvQuyChuan
            // 
            dgvQuyChuan.AllowUserToAddRows = false;
            dgvQuyChuan.AllowUserToDeleteRows = false;
            dgvQuyChuan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuyChuan.BackgroundColor = Color.White;
            dgvQuyChuan.BorderStyle = BorderStyle.None;
            dgvQuyChuan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuyChuan.Dock = DockStyle.Fill;
            dgvQuyChuan.EnableHeadersVisualStyles = false;
            dgvQuyChuan.Location = new Point(0, 0);
            dgvQuyChuan.MultiSelect = false;
            dgvQuyChuan.Name = "dgvQuyChuan";
            dgvQuyChuan.RowHeadersVisible = false;
            dgvQuyChuan.RowHeadersWidth = 51;
            dgvQuyChuan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvQuyChuan.Size = new Size(776, 245);
            dgvQuyChuan.TabIndex = 0;
            dgvQuyChuan.CellClick += dgvQuyChuan_CellClick;
            // 
            // UcQuyChuan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 247, 251);
            Controls.Add(pnlMainNew);
            Name = "UcQuyChuan";
            Size = new Size(816, 517);
            pnlToolbar.ResumeLayout(false);
            pnlToolbar.PerformLayout();
            pnlGrid.ResumeLayout(false);
            pnlMainNew.ResumeLayout(false);
            pnlMainNew.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuyChuan).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lblTitle;
        private Label lblDescription;
        private Panel pnlToolbar;
        private TextBox txtTimKiem;
        private Button btnThem;
        private Panel pnlGrid;
        private Panel pnlMainNew;
        private Button btnXoa;
        private Button btnSua;
        private Button btnLamMoi;
        private DataGridView dgvQuyChuan;
    }
}
