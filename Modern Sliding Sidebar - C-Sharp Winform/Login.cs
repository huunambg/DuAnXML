using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class Login : Form
    {

        string fileName = @"D:\Soure_Code\Window\BaoCaoXMLNhom3\Modern Sliding Sidebar - C-Sharp Winform\TaiKhoan.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_taikhoan;

        public Login()
        {
            InitializeComponent();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            doc.Load(fileName);

            ql_taikhoan = doc.DocumentElement;
            XmlNode check_tk = ql_taikhoan.SelectSingleNode("TaiKhoan[TaiKhoan ='" + txt_taikhoan.Text + "']");


            if (check_tk != null)
            {
                if (check_tk.SelectSingleNode("MatKhau").InnerText == txt_matkhau.Text)
                {
                    Form1 f = new Form1(check_tk.SelectSingleNode("@id_TaiKhoan").Value.ToString());
                    f.Show();
                    this.Hide();
                    MessageBox.Show("Đăng nhập thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Đăng nhập thất bại");
                }

            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại", "Đăng nhập thất bại");
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



