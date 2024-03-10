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
    public partial class Form4 : Form
    {
        string id_taikhoan;
        String namefile = "D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\KhachHang.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_kh;
        private string ma_kh;

        public Form4(string id_taikhoan)
        {
            InitializeComponent();
            this.id_taikhoan = id_taikhoan;
        }
        private void Show(DataGridView dgv)
        {
            dgv.Rows.Clear();
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_KhachHang.SelectNodes("KhachHang");
            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {

                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaKH").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenKH").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("DiaChi").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("SDT").InnerText;
                sd++;
                serialNumber++;
            }
        }
        

        
        private void Form4_Load(object sender, EventArgs e)
        {
            Show(dgv_kh);
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_KhachHang.SelectNodes("KhachHang");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_KhachHang.SelectNodes("KhachHang");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_KhachHang.SelectNodes("KhachHang");
        }

        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
