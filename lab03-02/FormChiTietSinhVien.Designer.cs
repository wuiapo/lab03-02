namespace lab03_02
{
    partial class FormChiTietSinhVien
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
            lblMaSV = new Label();
            lblHoVaTen = new Label();
            lblNgaySinh = new Label();
            lblGioiTinh = new Label();
            lblKhoa = new Label();
            lblDiemTB = new Label();
            txtMaSV = new TextBox();
            txtHoVaTen = new TextBox();
            txtDiemTB = new TextBox();
            dtpNgaySinh = new DateTimePicker();
            radNam = new RadioButton();
            radNu = new RadioButton();
            cboKhoa = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            SuspendLayout();
            // 
            // lblMaSV
            // 
            lblMaSV.AutoSize = true;
            lblMaSV.Location = new Point(40, 54);
            lblMaSV.Name = "lblMaSV";
            lblMaSV.Size = new Size(51, 20);
            lblMaSV.TabIndex = 0;
            lblMaSV.Text = "Mã SV";
            // 
            // lblHoVaTen
            // 
            lblHoVaTen.AutoSize = true;
            lblHoVaTen.Location = new Point(40, 103);
            lblHoVaTen.Name = "lblHoVaTen";
            lblHoVaTen.Size = new Size(73, 20);
            lblHoVaTen.TabIndex = 1;
            lblHoVaTen.Text = "Họ và tên";
            lblHoVaTen.Click += lblHoVaTen_Click;
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Location = new Point(40, 159);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(74, 20);
            lblNgaySinh.TabIndex = 2;
            lblNgaySinh.Text = "Ngày sinh";
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Location = new Point(40, 208);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(65, 20);
            lblGioiTinh.TabIndex = 3;
            lblGioiTinh.Text = "Giới tính";
            // 
            // lblKhoa
            // 
            lblKhoa.AutoSize = true;
            lblKhoa.Location = new Point(40, 256);
            lblKhoa.Name = "lblKhoa";
            lblKhoa.Size = new Size(43, 20);
            lblKhoa.TabIndex = 4;
            lblKhoa.Text = "Khoa";
            // 
            // lblDiemTB
            // 
            lblDiemTB.AutoSize = true;
            lblDiemTB.Location = new Point(40, 309);
            lblDiemTB.Name = "lblDiemTB";
            lblDiemTB.Size = new Size(66, 20);
            lblDiemTB.TabIndex = 5;
            lblDiemTB.Text = "Điểm TB";
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(159, 54);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(249, 27);
            txtMaSV.TabIndex = 6;
            // 
            // txtHoVaTen
            // 
            txtHoVaTen.Location = new Point(159, 103);
            txtHoVaTen.Name = "txtHoVaTen";
            txtHoVaTen.Size = new Size(249, 27);
            txtHoVaTen.TabIndex = 7;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(158, 309);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(125, 27);
            txtDiemTB.TabIndex = 8;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(158, 159);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(250, 27);
            dtpNgaySinh.TabIndex = 9;
            dtpNgaySinh.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(158, 206);
            radNam.Name = "radNam";
            radNam.Size = new Size(62, 24);
            radNam.TabIndex = 10;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(238, 206);
            radNu.Name = "radNu";
            radNu.Size = new Size(50, 24);
            radNu.TabIndex = 11;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // cboKhoa
            // 
            cboKhoa.FormattingEnabled = true;
            cboKhoa.Location = new Point(158, 256);
            cboKhoa.Name = "cboKhoa";
            cboKhoa.Size = new Size(250, 28);
            cboKhoa.TabIndex = 12;
            // 
            // btnLuu
            // 
            btnLuu.BackColor = Color.Lime;
            btnLuu.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLuu.ForeColor = Color.White;
            btnLuu.Location = new Point(61, 404);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(142, 54);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            btnHuy.BackColor = Color.Gray;
            btnHuy.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnHuy.ForeColor = Color.White;
            btnHuy.Location = new Point(259, 404);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(149, 54);
            btnHuy.TabIndex = 14;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = false;
            // 
            // FormChiTietSinhVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 569);
            Controls.Add(btnHuy);
            Controls.Add(btnLuu);
            Controls.Add(cboKhoa);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(dtpNgaySinh);
            Controls.Add(txtDiemTB);
            Controls.Add(txtHoVaTen);
            Controls.Add(txtMaSV);
            Controls.Add(lblDiemTB);
            Controls.Add(lblKhoa);
            Controls.Add(lblGioiTinh);
            Controls.Add(lblNgaySinh);
            Controls.Add(lblHoVaTen);
            Controls.Add(lblMaSV);
            Name = "FormChiTietSinhVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormChiTietSinhVien";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMaSV;
        private Label lblHoVaTen;
        private Label lblNgaySinh;
        private Label lblGioiTinh;
        private Label lblKhoa;
        private Label lblDiemTB;
        private TextBox txtMaSV;
        private TextBox txtHoVaTen;
        private TextBox txtDiemTB;
        private DateTimePicker dtpNgaySinh;
        private RadioButton radNam;
        private RadioButton radNu;
        private ComboBox cboKhoa;
        private Button btnLuu;
        private Button btnHuy;
    }
}