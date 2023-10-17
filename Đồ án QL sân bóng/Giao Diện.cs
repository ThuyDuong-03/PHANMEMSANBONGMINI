using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_QL_sân_bóng
{
    public partial class Giao_Diện : Form
    {
        private Form currentForm;

        public Giao_Diện()
        {
            InitializeComponent();
        }
        public void HidePanelMoving()
        {
            panelMain.Visible = false;//lam cho panelmoving ẩn đi
        }


        private void MovePanelToButton(Guna.UI2.WinForms.Guna2Button button)
        {
            panelMain.Top = button.Top;//điều chỉnh vị trí panelmoving dọc với button
        }
        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            ThongKeBaoCao c = new ThongKeBaoCao();
            c.TopLevel = false;
            c.FormBorderStyle = FormBorderStyle.None;
            c.Dock = DockStyle.Fill;
            panelgiaodien.Controls.Add(c);
            c.Show();

            currentForm = c;
            MovePanelToButton(btnThongKe);
            lblmain.Text = "Thống kê báo cáo";
            pictureBox1.Visible = false;
        }

        private void guna2PictureBox1_Click(object sender   , EventArgs e)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }

            // Thêm lại picture box vào panelgiaodien
            panelgiaodien.Controls.Add(pictureBox1);

            panelgiaodien.Controls.Clear();
            panelMain.Visible = true;

            lblmain.Text = "Trang chủ";
        }

        private void guna2CirclePictureBox6_Click(object sender, EventArgs e)
        {
            this.Close();  
        }

    }
}
