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
    public partial class Form5 : Form
    {
        XmlElement ql_nhanvien;
        String filename = "D:\\zKiemlongJr\\XML\\BaoCaoXML_Nhom3\\Modern Sliding Sidebar - C-Sharp Winform\\NhanVien.xml";
        private String ma_nv;
        XmlDocument doc = new XmlDocument();

        
        public void show(DataGridView dgv)
        {
            doc.Load(filename);
            ql_nhanvien = doc.DocumentElement;
            XmlNodeList ds = ql_nhanvien.SelectNodes("NhanVien");
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
        public Form5()
        {
            InitializeComponent();
            this.ma_nv = ma_nv;
        }

        private void dgv_nv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
