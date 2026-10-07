namespace lab03_02
{
    partial class FormDanhSachSV
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvSinhVien = new DataGridView();
            colMaSV = new DataGridViewTextBoxColumn();
            colHoVaTen = new DataGridViewTextBoxColumn();
            colNgaySinh = new DataGridViewTextBoxColumn();
            colGioiTinh = new DataGridViewTextBoxColumn();
            colKhoa = new DataGridViewTextBoxColumn();
            colDiemTB = new DataGridViewTextBoxColumn();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            lblTongSo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.AllowUserToAddRows = false;
            dgvSinhVien.AllowUserToDeleteRows = false;
            dgvSinhVien.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvSinhVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSinhVien.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(0, 120, 215);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvSinhVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Columns.AddRange(new DataGridViewColumn[] { colMaSV, colHoVaTen, colNgaySinh, colGioiTinh, colKhoa, colDiemTB });
            dgvSinhVien.EnableHeadersVisualStyles = false;
            dgvSinhVien.Location = new Point(16, 124);
            dgvSinhVien.MultiSelect = false;
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.ReadOnly = true;
            dgvSinhVien.RowHeadersVisible = false;
            dgvSinhVien.RowHeadersWidth = 51;
            dgvSinhVien.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSinhVien.Size = new Size(763, 280);
            dgvSinhVien.TabIndex = 0;
            // 
            // colMaSV
            // 
            colMaSV.DataPropertyName = "MaSV";
            colMaSV.HeaderText = "Mã SV";
            colMaSV.MinimumWidth = 6;
            colMaSV.Name = "colMaSV";
            colMaSV.ReadOnly = true;
            // 
            // colHoVaTen
            // 
            colHoVaTen.DataPropertyName = "HoTen";
            colHoVaTen.HeaderText = "Họ và tên";
            colHoVaTen.MinimumWidth = 6;
            colHoVaTen.Name = "colHoVaTen";
            colHoVaTen.ReadOnly = true;
            // 
            // colNgaySinh
            // 
            colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = "dd/MM/yyyy";
            colNgaySinh.DefaultCellStyle = dataGridViewCellStyle2;
            colNgaySinh.HeaderText = "Ngày sinh";
            colNgaySinh.MinimumWidth = 6;
            colNgaySinh.Name = "colNgaySinh";
            colNgaySinh.ReadOnly = true;
            // 
            // colGioiTinh
            // 
            colGioiTinh.DataPropertyName = "GioiTinh";
            colGioiTinh.HeaderText = "Giới tính";
            colGioiTinh.MinimumWidth = 6;
            colGioiTinh.Name = "colGioiTinh";
            colGioiTinh.ReadOnly = true;
            // 
            // colKhoa
            // 
            colKhoa.DataPropertyName = "Khoa";
            colKhoa.HeaderText = "Khoa";
            colKhoa.MinimumWidth = 6;
            colKhoa.Name = "colKhoa";
            colKhoa.ReadOnly = true;
            // 
            // colDiemTB
            // 
            colDiemTB.DataPropertyName = "DiemTB";
            colDiemTB.HeaderText = "Điểm TB";
            colDiemTB.MinimumWidth = 6;
            colDiemTB.Name = "colDiemTB";
            colDiemTB.ReadOnly = true;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.LimeGreen;
            btnThem.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.ForeColor = SystemColors.Control;
            btnThem.Location = new Point(16, 41);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(169, 55);
            btnThem.TabIndex = 1;
            btnThem.Text = "Them";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.DeepSkyBlue;
            btnSua.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSua.ForeColor = SystemColors.Control;
            btnSua.Location = new Point(217, 41);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(169, 55);
            btnSua.TabIndex = 2;
            btnSua.Text = "Sua";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.Red;
            btnXoa.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.ForeColor = SystemColors.Control;
            btnXoa.Location = new Point(414, 41);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(169, 55);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xoa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // lblTongSo
            // 
            lblTongSo.AutoSize = true;
            lblTongSo.Location = new Point(16, 421);
            lblTongSo.Name = "lblTongSo";
            lblTongSo.Size = new Size(61, 20);
            lblTongSo.TabIndex = 5;
            lblTongSo.Text = "Tong so";
            // 
            // FormDanhSachSV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTongSo);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(dgvSinhVien);
            Name = "FormDanhSachSV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sach sinh vien";
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Label lblTongSo;
        private DataGridViewTextBoxColumn colMaSV;
        private DataGridViewTextBoxColumn colHoVaTen;
        private DataGridViewTextBoxColumn colNgaySinh;
        private DataGridViewTextBoxColumn colGioiTinh;
        private DataGridViewTextBoxColumn colKhoa;
        private DataGridViewTextBoxColumn colDiemTB;
    }
}
