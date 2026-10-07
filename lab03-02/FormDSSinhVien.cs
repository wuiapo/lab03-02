using System.ComponentModel;

namespace lab03_02
{
    public partial class FormDanhSachSV : Form
    {
        // BindingList: Thêm/Xóa/Sửa phần tử thì lưới tự cập nhật
        private BindingList<SinhVien> dsSinhVien = new BindingList<SinhVien>();

        public FormDanhSachSV()
        {
            InitializeComponent();

            btnThem.Click += BtnThem_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            dgvSinhVien.CellFormatting += DgvSinhVien_CellFormatting;
            dgvSinhVien.DataBindingComplete += (s, e) => dgvSinhVien.ClearSelection();

            dgvSinhVien.AutoGenerateColumns = false;   // dùng cột đã thiết kế
            dgvSinhVien.DataSource = dsSinhVien;
            CapNhatTongSo();
        }

        

        private void CapNhatTongSo()
        {
            lblTongSo.Text = "Tổng số sinh viên: " + dsSinhVien.Count;
        }

        // ===== Yêu cầu 6: Điểm TB null -> "Chưa có" =====
        private void DgvSinhVien_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSinhVien.Columns[e.ColumnIndex].Name == "colDiemTB"
                && (e.Value == null || e.Value == DBNull.Value))
            {
                e.Value = "Chưa có";
                e.FormattingApplied = true;
            }
        }

        private SinhVien? LaySinhVienDangChon()
        {
            if (dgvSinhVien.SelectedRows.Count == 0) return null;
            return dgvSinhVien.SelectedRows[0].DataBoundItem as SinhVien;
        }

        private List<string> LayDanhSachMa()
        {
            return dsSinhVien.Select(sv => sv.MaSV).ToList();
        }

        // ===== Yêu cầu 3: luồng ShowDialog — THÊM =====
        private void BtnThem_Click(object? sender, EventArgs e)
        {
            using var f = new FormChiTietSinhVien(null, LayDanhSachMa());
            if (f.ShowDialog(this) == DialogResult.OK && f.KetQua != null)
            {
                dsSinhVien.Add(f.KetQua);
                CapNhatTongSo();
            }
        }

        // ===== Yêu cầu 3: luồng ShowDialog — SỬA =====
        private void BtnSua_Click(object? sender, EventArgs e)
        {
            SinhVien? sv = LaySinhVienDangChon();
            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần sửa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var f = new FormChiTietSinhVien(sv, LayDanhSachMa());
            if (f.ShowDialog(this) == DialogResult.OK && f.KetQua != null)
            {
                int viTri = dsSinhVien.IndexOf(sv);
                dsSinhVien[viTri] = f.KetQua;   // thay vào đúng vị trí cũ
            }
        }

        // ===== Yêu cầu 5: XÓA có xác nhận =====
        private void BtnXoa_Click(object? sender, EventArgs e)
        {
            SinhVien? sv = LaySinhVienDangChon();
            if (sv == null)
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Cảnh báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var xacNhan = MessageBox.Show(
                $"Bạn có chắc muốn xóa sinh viên \"{sv.HoTen}\" ({sv.MaSV})?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (xacNhan == DialogResult.Yes)
            {
                dsSinhVien.Remove(sv);
                CapNhatTongSo();
            }
        }
    }
}