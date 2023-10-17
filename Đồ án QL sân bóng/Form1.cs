using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Đồ_án_QL_sân_bóng
{
    public partial class Form1 : Form
    {
        private List<User> userList;
        public Form1()
        {
            InitializeComponent();
            InitializeUserList();
        }


        public class User
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public User(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }

        private void InitializeUserList()
        {
            // Thêm các tài khoản mẫu vào danh sách tạm thời
            userList = new List<User>
            {
                new User("admin", "admin123"),
                new User("pxt1808", "1808"),
                new User("duong2209", "password2")
            };
        }
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtDangNhap.Text;
            string matKhau = txtMatKhau.Text;

            if (tenDangNhap.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản!");
                return;
            }

            if (matKhau.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }

            // Kiểm tra xem tài khoản người dùng có tồn tại trong danh sách hay không
            User user = userList.FirstOrDefault(u => u.Username == tenDangNhap && u.Password == matKhau);

            if (user != null)
            {

                Giao_Diện a = new Giao_Diện();
                a.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác");
            }
        }   
           private bool hienMatKhau = false;

        private void ptcEye_Click(object sender, EventArgs e)
        {
            hienMatKhau = !hienMatKhau;
            if (hienMatKhau)
            {
                //biểu tượng con mắt hiện mật khẩu
                ptcEye.Image = Properties.Resources.con_mat_hien1;
                //hiển thị mật khẩu
                txtMatKhau.UseSystemPasswordChar = false;
            } else
            {
                //biểu tượng con mắt hiện mật khẩu
                ptcEye.Image = Properties.Resources.con_mat_an1;
                //ẩn thị mật khẩu
                txtMatKhau.UseSystemPasswordChar = true;
            }
         }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Transparent;
        }
    }
    }


