using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Windows.Forms;

namespace MetroMap_HCM
{
    public partial class frmMain : Form
    {
        private readonly string _userRole;

        public frmMain(string userRole)
        {
            InitializeComponent();
            _userRole = userRole;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Xin chào, bạn đang đăng nhập với quyền: {_userRole}";

            if (_userRole == "User")
            {
                // Ẩn các chức năng quản lý và thống kê cho người dùng
                mniGa.Visible = false;
                mniTuyen.Visible = false;
                mniLienKet.Visible = false;
                mniThongKe.Visible = false;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            pnlMain.Controls.Clear();
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            pnlMain.Controls.Add(childForm);
            childForm.Show();
        }

        private void mniGa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmGa());
        }

        private void mniTuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTuyen());
        }

        private void mniLienKet_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmLienKet());
        }

        private void mniTimDuong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTimDuong());
        }

        private void mniDatVe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDatVe());
        }

        private void mniThongKe_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKe());
        }

        private void mniDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn đăng xuất?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Hide();
                frmLogin login = new frmLogin();
                if (login.ShowDialog() == DialogResult.OK)
                {
                    frmMain main = new frmMain(login.UserRole);
                    main.Show();
                }
                this.Close();
            }
        }

        private void pbHero_Paint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;

            int w = pbHero.Width, h = pbHero.Height;
            int pad = 24;

            // ======= THÔNG SỐ DỄ CHỈNH =======
            float TitleCenterRatio = 0.80f;   // 0.62–0.70: kéo tiêu đề xuống dưới đường ray
            int SubtitleGap = 18;             // px: khoảng cách tiêu đề -> mô tả
                                              // =================================

            string title = "METRO INFO HO CHI MINH CITY";
            using (var titleFont = new Font("Times New Roman", 28f, FontStyle.Bold))
            using (var semi = new SolidBrush(Color.FromArgb(170, 0, 0, 0))) // nền mờ
            using (var textBrush = new SolidBrush(Color.White))
            {
                // Chiều cao khung mờ sau tiêu đề
                int th = (int)titleFont.GetHeight(g) + 18;

                // Tâm theo tỉ lệ chiều cao ảnh
                int yTitleCenter = (int)(h * TitleCenterRatio);

                // Khung mờ căn giữa theo yTitleCenter
                var rect = new Rectangle(pad, yTitleCenter - th / 2, w - pad * 2, th + 8);
                g.FillRectangle(semi, rect);

                var sf = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
                g.DrawString(title, titleFont, textBrush, new RectangleF(pad, rect.Y, w - pad * 2, rect.Height), sf);

                // ----- Dòng mô tả nhỏ -----
                string subtitle = "Map · Timetable · Fare · News — Updated December 2024";
                using (var subFont = new Font("Times New Roman", 16f, FontStyle.Regular))
                {
                    var sf2 = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Near };
                    float ySubtitleTop = rect.Bottom + SubtitleGap; // nằm dưới khung tiêu đề
                    g.DrawString(subtitle, subFont, textBrush, new RectangleF(pad, ySubtitleTop, w - pad * 2, 40), sf2);
                }
            }
        }
    }
}
