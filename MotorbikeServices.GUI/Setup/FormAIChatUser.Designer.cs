namespace MotorbikeServices.GUI.Setup
{
    partial class FormAIChatUser
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
            rtbChatHistory = new RichTextBox();
            txtInputMessage = new TextBox();
            btnSend = new Button();
            lblStatus = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.LemonChiffon;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1457, 75);
            label1.TabIndex = 7;
            label1.Text = "CHAT TRỢ LÝ ẢO (DAIDAIMOTOR)";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rtbChatHistory
            // 
            rtbChatHistory.Location = new Point(12, 121);
            rtbChatHistory.Name = "rtbChatHistory";
            rtbChatHistory.Size = new Size(1433, 557);
            rtbChatHistory.TabIndex = 8;
            rtbChatHistory.Text = "";
            // 
            // txtInputMessage
            // 
            txtInputMessage.Location = new Point(204, 706);
            txtInputMessage.Name = "txtInputMessage";
            txtInputMessage.PlaceholderText = "Mời bạn nhập câu hỏi vào đây...";
            txtInputMessage.Size = new Size(946, 27);
            txtInputMessage.TabIndex = 9;
            txtInputMessage.KeyDown += txtInputMessage_KeyDown;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.FromArgb(255, 128, 128);
            btnSend.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 163);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(1176, 684);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(176, 62);
            btnSend.TabIndex = 10;
            btnSend.Text = "GỬI";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 163);
            lblStatus.Location = new Point(12, 684);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(90, 23);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Trạng Thái";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Yellow;
            label2.Font = new Font("Segoe UI Black", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 163);
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(1138, 23);
            label2.TabIndex = 12;
            label2.Text = "*LƯU Ý: TRỢ LÝ DAIDAIMOTOR VẪN TRONG QUÁ TRÌNH PHÁT TRIỂN, KHI TRẢ LỜI KHÔNG ĐÚNG, MONG MỌI NGƯỜI THÔNG CẢM!";
            // 
            // FormAIChatUser
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1457, 758);
            Controls.Add(label2);
            Controls.Add(lblStatus);
            Controls.Add(btnSend);
            Controls.Add(txtInputMessage);
            Controls.Add(rtbChatHistory);
            Controls.Add(label1);
            Name = "FormAIChatUser";
            Text = "FormAIChatUser";
            Load += FormAIChatUser_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RichTextBox rtbChatHistory;
        private TextBox txtInputMessage;
        private Button btnSend;
        private Label lblStatus;
        private Label label2;
    }
}