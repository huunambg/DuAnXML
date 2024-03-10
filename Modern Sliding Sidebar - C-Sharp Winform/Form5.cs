using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class Form5 : Form
    {
        string id_taikhoan;
        XmlElement ql_nhanvien;
        String filename = "D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\NhanVien.xml";
        XmlDocument doc = new XmlDocument();

        
        public void show(DataGridView dgv)
        {
           dgv.Rows.Clear();
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_NhanVien.SelectNodes("NhanVien");
            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaNV").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenNV").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("ChucVu").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("SDT").InnerText;
                dgv.Rows[sd].Cells[5].Value = node.SelectSingleNode("DiaChi").InnerText;
                sd++;
                serialNumber++;
            }
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            show(dgv_nv);
        }
        public Form5(string id_taikhoan)
        {
            InitializeComponent();
            this.id_taikhoan = id_taikhoan;
        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNode DS_NhanVien = ql_nhanvien.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");
        }
    }
}
