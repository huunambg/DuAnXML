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
        String namefile = "D:\\zKiemlongJr\\XML\\BaoCaoXML_Nhom3\\Modern Sliding Sidebar - C-Sharp Winform\\KhachHang.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_kh;
        private string ma_kh;

        public Form4()
        {
            InitializeComponent();
        }
        private void Show(DataGridView dgv)
        {
            doc.Load(namefile);
            ql_kh = doc.DocumentElement;
            XmlNodeList ds = ql_kh.SelectNodes("KhachHang");
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

        }

        private void btn_sua_Click(object sender, EventArgs e)
        {

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {

        }

        private void dgv_kh_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_kh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
