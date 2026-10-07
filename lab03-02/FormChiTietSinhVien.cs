using System.Globalization;

namespace lab03_02
{
    public partial class FormChiTietSinhVien : Form
    {
        // Kết quả trả về cho form cha (chỉ có giá trị khi DialogResult = OK)
        public SinhVien? KetQua { get; private set; }

        private readonly bool laCheDoSua;
        private readonly List<string> dsMaSVHienCo;

        // svCanSua == null -> THÊM ; svCanSua != null -> SỬA
        public FormChiTietSinhVien(SinhVien? svCanSua, List<string> danhSachMaSVHienCo)
        {
            InitializeComponent();
            laCheDoSua = svCanSua != null;
            dsMaSVHienCo = danhSachMaSVHienCo;

            cboKhoa.DropDownStyle = ComboBoxStyle.DropDownList;
            cboKhoa.Items.AddRange(new object[] {
                "Công nghệ thông tin", "Quản trị kinh doanh",
                "Kỹ thuật Công trình", "Ngôn ngữ Anh", "Dược" });
            dtpNgaySinh.Format = DateTimePickerFormat.Custom;
            dtpNgaySinh.CustomFormat = "dd/MM/yyyy";

            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            btnHuy.DialogResult = DialogResult.Cancel;  // bấm Hủy -> đóng, trả về Cancel
            AcceptButton = btnLuu;                      // Enter = Lưu
            CancelButton = btnHuy;                      // Esc = Hủy
            btnLuu.Click += BtnLuu_Click;

            // ===== Yêu cầu 1: nhận dữ liệu đầu vào =====
            if (svCanSua == null)
            {
                Text = "Thêm sinh viên mới";
                dtpNgaySinh.Value = new DateTime(2000, 1, 1);
                radNam.Checked = true;
                cboKhoa.SelectedIndex = 0;
            }
            else
            {
                Text = "Sửa thông tin sinh viên";
                txtMaSV.Text = svCanSua.MaSV;
                txtMaSV.ReadOnly = true;                // không cho sửa mã
                txtHoVaTen.Text = svCanSua.HoTen;
                dtpNgaySinh.Value = svCanSua.NgaySinh;
                radNam.Checked = svCanSua.GioiTinh == "Nam";
                radNu.Checked = !radNam.Checked;
                cboKhoa.SelectedItem = svCanSua.Khoa;
                txtDiemTB.Text = svCanSua.DiemTB?.ToString() ?? "";
            }
        }

        // ===== Yêu cầu 2: validate + trả kết quả =====
        private void BtnLuu_Click(object? sender, EventArgs e)
        {
            string maSV = txtMaSV.Text.Trim();
            string hoTen = txtHoVaTen.Text.Trim();

            if (maSV == "") { BaoLoi("Mã SV không được để trống!", txtMaSV); return; }
            if (hoTen == "") { BaoLoi("Họ tên không được để trống!", txtHoVaTen); return; }
            if (cboKhoa.SelectedIndex < 0) { BaoLoi("Vui lòng chọn Khoa!", cboKhoa); return; }

            double? diem = null;
            string chuoiDiem = txtDiemTB.Text.Trim();
            if (chuoiDiem != "")
            {
                bool laSo = double.TryParse(chuoiDiem.Replace(',', '.'), NumberStyles.Float,
                                            CultureInfo.InvariantCulture, out double d);
                if (!laSo || d < 0 || d > 10)
                {
                    BaoLoi("Điểm TB phải là số từ 0 đến 10!", txtDiemTB);
                    return;
                }
                diem = d;
            }

            // ===== Yêu cầu 4: kiểm tra trùng mã (chỉ khi Thêm) =====
            if (!laCheDoSua && dsMaSVHienCo.Any(ma =>
                    string.Equals(ma, maSV, StringComparison.OrdinalIgnoreCase)))
            {
                BaoLoi("Mã SV \"" + maSV + "\" đã tồn tại!", txtMaSV);
                return;
            }

            KetQua = new SinhVien
            {
                MaSV = maSV,
                HoTen = hoTen,
                NgaySinh = dtpNgaySinh.Value.Date,
                GioiTinh = radNam.Checked ? "Nam" : "Nữ",
                Khoa = cboKhoa.SelectedItem?.ToString() ?? "",
                DiemTB = diem
            };
            DialogResult = DialogResult.OK;   // gán DialogResult -> form tự đóng
        }

        private void BaoLoi(string thongBao, Control oLoi)
        {
            MessageBox.Show(thongBao, "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            oLoi.Focus();
            if (oLoi is TextBox tb) tb.SelectAll();
        }
        private void lblHoVaTen_Click(object sender, EventArgs e) { }
    }
}