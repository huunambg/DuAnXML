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
    public partial class Form3 : Form
    {
        string id_taikhoan;
        String namefile = "D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\HoaDon.xml";
        XmlDocument doc = new XmlDocument();
        XmlElement ql_hoadon;
        String filenamesp = "D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\SanPham.xml";
        XmlElement ql_sanpham;
        XmlDocument doc2 = new XmlDocument();
        String filenamenv = "D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\NhanVien.xml";
        XmlElement ql_nv;
        XmlDocument doc3 = new XmlDocument();

        String filenamekh = "D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\KhachHang.xml";
        XmlElement ql_kh;
        XmlDocument doc4 = new XmlDocument();



        private List<string> dsSP = new List<string>();
        private List<string> dsKH= new List<string>();
        public Form3(string id_taikhoan)
        {
            InitializeComponent();
            this.id_taikhoan = id_taikhoan;

        }

        private void dgv_hoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgv_hoadon.CurrentCell.RowIndex;
            if (dgv_hoadon.Rows[index].Cells[1].Value != null)
            {
                showChitiet( dgv_hoadon.Rows[index].Cells[1].Value.ToString());
            }

           

        }


      void loadcombobox()
        {

            doc3.Load(filenamenv);

            ql_nv = doc3.DocumentElement;

            XmlNode DS_NV = ql_nv.SelectSingleNode("DS_NhanVien[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_NV.SelectNodes("NhanVien");



            foreach (XmlNode node in ds)
            {
                cbx_manv.Items.Add(node.SelectSingleNode("@MaNV").Value);

            }
            cbx_manv.SelectedIndex=0;




        }

        void showChitiet(string id_HD)
        {


 

            dgv_chitiethoadon.Rows.Clear();
            doc.Load(namefile);
            ql_hoadon = doc.DocumentElement;

            XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");


            XmlNode HoaDon= DS_HoaDon.SelectSingleNode("HoaDon[@MaHD ='" + id_HD + "']");


            XmlNodeList ds = HoaDon.SelectNodes("SanPham");


            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {

                dgv_chitiethoadon.Rows.Add();
                dgv_chitiethoadon.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv_chitiethoadon.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaSanPham").Value;
                dgv_chitiethoadon.Rows[sd].Cells[2].Value = node.SelectSingleNode("TenSP").InnerText;
                dgv_chitiethoadon.Rows[sd].Cells[3].Value = node.SelectSingleNode("SoLuong").InnerText;
                dgv_chitiethoadon.Rows[sd].Cells[4].Value = node.SelectSingleNode("GiaBan").InnerText;
                dgv_chitiethoadon.Rows[sd].Cells[5].Value = node.SelectSingleNode("ThanhTien").InnerText;
                sd++;
                serialNumber++;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            show(dgv_hoadon);
            LoadAutocompletetxtFromXml();
            SetupAutoComplete();
            loadcombobox();
        }

        void show(DataGridView dgv)
        {
            dgv.Rows.Clear();
            doc.Load(namefile);
            ql_hoadon = doc.DocumentElement;

            XmlNode DS_KhachHang = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_KhachHang.SelectNodes("HoaDon");
            string maHD = "HD" + (ds.Count+1).ToString();
            txt_mahd.Text = maHD;
            int sd = 0;
            int serialNumber = 1;
            foreach (XmlNode node in ds)
            {

                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = serialNumber.ToString();
                dgv.Rows[sd].Cells[1].Value = node.SelectSingleNode("@MaHD").Value;
                dgv.Rows[sd].Cells[2].Value = node.SelectSingleNode("NgayDat").InnerText;
                dgv.Rows[sd].Cells[3].Value = node.SelectSingleNode("MaNV").InnerText;
                dgv.Rows[sd].Cells[4].Value = node.SelectSingleNode("MaKH").InnerText;
                sd++;
                serialNumber++;
            }

        }

        private void dgv_hoadon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


        private void LoadAutocompletetxtFromXml()
        {

            doc2.Load(filenamesp);

            ql_sanpham = doc2.DocumentElement;

            doc4.Load(filenamekh);

            ql_kh = doc4.DocumentElement;


            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_SanPham.SelectNodes("SanPham");


            XmlNode DS_KH = ql_kh.SelectSingleNode("DS_KhachHang[Id_TaiKhoan ='" + this.id_taikhoan + "']");
           
            XmlNodeList ds_kh = DS_KH.SelectNodes("KhachHang");
            foreach(XmlNode node in ds_kh)
            {

                dsKH.Add(node.SelectSingleNode("@MaKH").Value);
            }



            foreach (XmlNode node in ds)
            {
                dsSP.Add(node.SelectSingleNode("TenSP").InnerText);
            }
        }
        private void SetupAutoComplete()
        {
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(dsSP.ToArray());
            txt_tensp2.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_tensp2.AutoCompleteCustomSource = source;
            txt_tensp2.AutoCompleteMode = AutoCompleteMode.Suggest;

            AutoCompleteStringCollection source2 = new AutoCompleteStringCollection();

            source2.AddRange(dsKH.ToArray());

            txt_makh.AutoCompleteSource = AutoCompleteSource.CustomSource;
            txt_makh.AutoCompleteCustomSource = source2;
            txt_makh.AutoCompleteMode = AutoCompleteMode.Suggest;



        }

        private void txt_cthd_TextChanged(object sender, EventArgs e)
        {

            doc2.Load(filenamesp);
            ql_sanpham = doc2.DocumentElement;


            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_SanPham.SelectNodes("SanPham");
            foreach (XmlNode node in ds)
            {
                if (txt_cthd.Text == node.SelectSingleNode("@MaSP").InnerText)
                {
                    txt_tensp2.Text = node.SelectSingleNode("TenSP").InnerText;
                    txt_giaban.Text = node.SelectSingleNode("Gia").InnerText;
                }

            }

        }

        private void txt_tensp2_TextChanged(object sender, EventArgs e)
        {
            doc2.Load(filenamesp);
            ql_sanpham = doc2.DocumentElement;


            XmlNode DS_SanPham = ql_sanpham.SelectSingleNode("DS_SanPham[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNodeList ds = DS_SanPham.SelectNodes("SanPham");
            foreach (XmlNode node in ds)
            {
                if (txt_tensp2.Text == node.SelectSingleNode("TenSP").InnerText)
                {

                    txt_cthd.Text = node.SelectSingleNode("@MaSP").Value;
                    txt_giaban.Text = node.SelectSingleNode("Gia").InnerText;
                }

            }
        }

        private void txt_soluong_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int sl = int.Parse(txt_soluong.Text);
                int dongia = int.Parse(txt_giaban.Text);
                int thanhtien = sl * dongia;
                txt_thanhtien.Text = thanhtien.ToString();
            }
            catch (Exception ex) { }
           
            
        }

        private void btn_themhd_Click(object sender, EventArgs e)
        {
            doc.Load(namefile);
            ql_hoadon = doc.DocumentElement;

            XmlNode DS_HoaDon = ql_hoadon.SelectSingleNode("DS_HoaDon[Id_TaiKhoan ='" + this.id_taikhoan + "']");

            XmlNode HoaDon = doc.CreateElement("HoaDon");


            XmlAttribute MaHoaDon = doc.CreateAttribute("MaHD");
            MaHoaDon.Value = txt_mahd.Text;
            HoaDon.Attributes.Append(MaHoaDon);

            XmlElement ngaydat = doc.CreateElement("NgayDat");
            ngaydat.InnerText = txt_ngaymua.Text;
            HoaDon.AppendChild(ngaydat);

            XmlElement MaNV = doc.CreateElement("MaNV");
            MaNV.InnerText = cbx_manv.Text;
            HoaDon.AppendChild(MaNV);

            XmlElement MaKH = doc.CreateElement("MaKH");
            MaKH.InnerText = txt_makh.Text;
            HoaDon.AppendChild(MaKH);


            DS_HoaDon.AppendChild(HoaDon);

            doc.Save(namefile);

            show(dgv_hoadon);






        }

        private void txt_manv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_makh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
