using System;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab03_02
{
    public partial class MainForm : Form
    {
        private const string TieuDeGoc = "Soạn thảo văn bản";
        private const string FontMacDinh = "Tahoma";
        private const float CoMacDinh = 14F;

        private string duongDan = null;      // file đang mở / đã lưu (null = văn bản mới chưa lưu)
        private bool dangCapNhat = false;    // chặn xử lý lặp khi cập nhật thanh công cụ bằng code

        public MainForm()
        {
            InitializeComponent();

            // 2.1 Khi mở Form: nạp danh sách font hệ thống + giá trị mặc định Tahoma, 14
            NapDanhSachFont();
            DatMacDinh();
        }

        // ================= 2.1 + 2.2 KHỞI TẠO / TẠO MỚI =================
        private void NapDanhSachFont()
        {
            cmbFonts.Items.Clear();
            using (var fonts = new InstalledFontCollection())
            {
                foreach (FontFamily font in fonts.Families)
                    cmbFonts.Items.Add(font.Name);
            }
        }

        private void DatMacDinh()
        {
            richText.Clear();
            richText.ForeColor = Color.Black;
            richText.Font = new Font(FontMacDinh, CoMacDinh);
            duongDan = null;
            Text = TieuDeGoc;
            CapNhatThanhCongCu();
            CapNhatSoTu();
        }

        private void TaoMoi_Click(object sender, EventArgs e)
        {
            DatMacDinh();
        }

        // ================= 2.3 MỞ TẬP TIN =================
        private void MoTapTin_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            string p = openFileDialog.FileName;
            try
            {
                if (Path.GetExtension(p).Equals(".rtf", StringComparison.OrdinalIgnoreCase))
                {
                    richText.LoadFile(p, RichTextBoxStreamType.RichText);
                }
                else
                {
                    // File .txt: đọc bằng File.ReadAllText để hiển thị đúng tiếng Việt Unicode
                    richText.ForeColor = Color.Black;
                    richText.Font = new Font(FontMacDinh, CoMacDinh);
                    richText.Text = File.ReadAllText(p);
                }
                duongDan = p;
                Text = TieuDeGoc + " - " + Path.GetFileName(p);
                CapNhatThanhCongCu();
                CapNhatSoTu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở tập tin.\n\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ================= 2.4 LƯU NỘI DUNG =================
        private void LuuTapTin_Click(object sender, EventArgs e)
        {
            if (duongDan == null)
            {
                // Văn bản mới, chưa lưu lần nào -> hộp thoại lưu (mặc định *.rtf)
                if (saveFileDialog.ShowDialog() != DialogResult.OK) return;
                if (!GhiFile(saveFileDialog.FileName)) return;

                duongDan = saveFileDialog.FileName;
                Text = TieuDeGoc + " - " + Path.GetFileName(duongDan);
            }
            else
            {
                // Văn bản đã mở/lưu trước đó -> lưu thẳng và thông báo
                if (GhiFile(duongDan))
                    MessageBox.Show("Đã lưu nội dung văn bản thành công!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool GhiFile(string p)
        {
            try
            {
                if (Path.GetExtension(p).Equals(".txt", StringComparison.OrdinalIgnoreCase))
                    File.WriteAllText(p, richText.Text, new UTF8Encoding(true));
                else
                    richText.SaveFile(p, RichTextBoxStreamType.RichText);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể lưu tập tin.\n\n" + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        // ================= MENU ĐỊNH DẠNG (FontDialog) =================
        private void mnuDinhDang_Click(object sender, EventArgs e)
        {
            fontDialog.Font = richText.SelectionFont ?? richText.Font;
            fontDialog.Color = richText.SelectionColor.IsEmpty ? richText.ForeColor : richText.SelectionColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
                ApDungFontDialog();
        }

        private void fontDialog_Apply(object sender, EventArgs e)
        {
            ApDungFontDialog();
        }

        private void fontDialog_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Chọn font, kiểu chữ, cỡ chữ, hiệu ứng và màu chữ, rồi nhấn OK hoặc Apply.",
                "Trợ giúp", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ApDungFontDialog()
        {
            if (richText.SelectionLength > 0)
            {
                // Có vùng chọn: chỉ áp dụng cho phần đang chọn
                richText.SelectionFont = fontDialog.Font;
                richText.SelectionColor = fontDialog.Color;
            }
            else
            {
                // Không chọn gì: áp dụng cho toàn bộ văn bản (theo hướng dẫn của đề)
                richText.ForeColor = fontDialog.Color;
                richText.Font = fontDialog.Font;
            }
            CapNhatThanhCongCu();
        }

        // ================= FONT / SIZE / B - I - U TRÊN THANH CÔNG CỤ =================
        private void cmbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dangCapNhat || cmbFonts.SelectedIndex < 0) return;
            string ten = cmbFonts.SelectedItem.ToString();
            BienDoiFont(f => new Font(ten, f.Size, f.Style));
            richText.Focus();
        }

        private void cmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApDungCoChu();
        }

        private void cmbSize_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            ApDungCoChu();
        }

        private void ApDungCoChu()
        {
            if (dangCapNhat) return;

            string s = cmbSize.Text.Trim().Replace(',', '.');
            if (!float.TryParse(s, NumberStyles.Float, CultureInfo.InvariantCulture, out float co) || co < 1 || co > 1000)
            {
                MessageBox.Show("Cỡ chữ không hợp lệ (nhập số từ 1 đến 1000).", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CapNhatThanhCongCu();
                return;
            }

            BienDoiFont(f => new Font(f.FontFamily, co, f.Style));
            richText.Focus();
        }

        private void btnDam_Click(object sender, EventArgs e) { DoiKieu(FontStyle.Bold, btnDam.Checked); }
        private void btnNghieng_Click(object sender, EventArgs e) { DoiKieu(FontStyle.Italic, btnNghieng.Checked); }
        private void btnGachChan_Click(object sender, EventArgs e) { DoiKieu(FontStyle.Underline, btnGachChan.Checked); }

        // Bật/tắt một kiểu chữ tùy theo trạng thái của nút
        private void DoiKieu(FontStyle kieu, bool bat)
        {
            BienDoiFont(f => new Font(f, bat ? (f.Style | kieu) : (f.Style & ~kieu)));
            richText.Focus();
        }

        // Áp dụng một phép biến đổi font lên vùng đang chọn (hoặc vị trí con trỏ)
        private void BienDoiFont(Func<Font, Font> bienDoi)
        {
            if (richText.SelectionLength == 0 || richText.SelectionFont != null)
            {
                Font hienTai = richText.SelectionFont ?? richText.Font;
                Font moi = TaoFont(bienDoi, hienTai);
                if (moi != null) richText.SelectionFont = moi;
                return;
            }

            // Vùng chọn có nhiều font khác nhau -> xử lý từng ký tự để giữ nguyên các phần còn lại
            int batDau = richText.SelectionStart;
            int dai = richText.SelectionLength;
            dangCapNhat = true;
            try
            {
                for (int i = batDau; i < batDau + dai; i++)
                {
                    richText.Select(i, 1);
                    Font f = richText.SelectionFont;
                    if (f == null) continue;
                    Font moi = TaoFont(bienDoi, f);
                    if (moi != null) richText.SelectionFont = moi;
                }
            }
            finally
            {
                richText.Select(batDau, dai);
                dangCapNhat = false;
            }
            CapNhatThanhCongCu();
        }

        private static Font TaoFont(Func<Font, Font> bienDoi, Font f)
        {
            try { return bienDoi(f); }
            catch (ArgumentException) { return null; }   // font không hỗ trợ kiểu chữ này
        }

        // ================= ĐỒNG BỘ THANH CÔNG CỤ + ĐẾM TỪ =================
        private void richText_SelectionChanged(object sender, EventArgs e)
        {
            CapNhatThanhCongCu();
        }

        private void richText_TextChanged(object sender, EventArgs e)
        {
            CapNhatSoTu();
        }

        private void CapNhatThanhCongCu()
        {
            if (dangCapNhat) return;
            dangCapNhat = true;
            try
            {
                Font f = richText.SelectionFont;
                if (f != null)
                {
                    cmbFonts.SelectedIndex = cmbFonts.Items.IndexOf(f.Name);
                    cmbSize.Text = f.Size.ToString("0.##", CultureInfo.InvariantCulture);
                    btnDam.Checked = f.Bold;
                    btnNghieng.Checked = f.Italic;
                    btnGachChan.Checked = f.Underline;
                }
                else
                {
                    // Vùng chọn gồm nhiều font khác nhau
                    cmbFonts.SelectedIndex = -1;
                    cmbSize.Text = "";
                    btnDam.Checked = false;
                    btnNghieng.Checked = false;
                    btnGachChan.Checked = false;
                }
            }
            finally
            {
                dangCapNhat = false;
            }
        }

        private void CapNhatSoTu()
        {
            string[] tu = richText.Text.Split(new[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            lblTongTu.Text = "Tổng số từ: " + tu.Length;
        }
    }
}
