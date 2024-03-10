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
    public partial class Form2 : Form
    {
        String ma_sp;
        XmlDocument doc = new XmlDocument();
        String filename = "D:\\zKiemlongJr\\XML\\BaoCaoXML_Nhom3\\Modern Sliding Sidebar - C-Sharp Winform\\SanPham.xml";
        XmlElement ql_sanpham;
        
        private void Show(DataGridView dgv)
        {
            doc.Load(filename);
            ql_sanpham = doc.DocumentElement;
            XmlNodeList ds = ql_sanpham.SelectNodes("SanPham");
            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaSP").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenSP").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("Gia").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("SoLuongTon").InnerText;
                dgv.Rows[sd].Cells[5].Value = node.SelectSingleNode("NgaySX").InnerText;
                dgv.Rows[sd].Cells[6].Value = node.SelectSingleNode("HanSD").InnerText;
                sd++;
                serialNumber++;
            }
        }
        public Form2()
        {
            InitializeComponent();
            this.ma_sp = ma_sp;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Show(dgv_sp);
        }

        private void dgv_sp_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
