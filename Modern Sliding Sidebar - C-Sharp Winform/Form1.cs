﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class Form1 : Form
    {
        bool sideBar_Expand = true;
        public Form1()
        {
            InitializeComponent();
            About f = new About();
            f.TopLevel = false;
            f.Size = gunaElipsePanel1.Size; // Set size of the new form to match PanelMain
            gunaElipsePanel1.Controls.Clear();
            gunaElipsePanel1.Controls.Add(f);
            f.Show();
            gunaElipsePanel1.SizeChanged += (s, ev) => { f.Size = gunaElipsePanel1.Size; };
            f.SizeChanged += (s, ev) => { gunaElipsePanel1.Size = f.Size; };
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private void Close_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
                {
                    SideBar.Width += 10;
                    if (SideBar.Width == SideBar.MaximumSize.Width)
                    {
                        sideBar_Expand = true;
                        Timer_Sidebar_Menu.Stop();
                    }
                }
        }   
        
        

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }




        
        bool isMaximized = false; // khởi tạo biến lưu trạng thái cửa sổ
        private void gunaImageButton2_Click(object sender, EventArgs e)
        {
            if (!isMaximized) // nếu cửa sổ chưa được phóng to
            {
                this.WindowState = FormWindowState.Maximized; // phóng to cửa sổ
                gunaImageButton2.Image = Image.FromFile("D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\access\\tab.png");
                isMaximized = true; // đánh dấu là đã phóng to
            }
            else
            {

                this.WindowState = FormWindowState.Normal; // khôi phục trạng thái cửa sổ trước đó
                gunaImageButton2.Image = Image.FromFile("D:\\Soure_Code\\Window\\BaoCaoXMLNhom3\\Modern Sliding Sidebar - C-Sharp Winform\\access\\maximum.png");
                isMaximized = false; // đánh dấu là chưa phóng to
            }
        }

        private void gunaImageButton3_Click(object sender, EventArgs e)
        {
                this.WindowState = FormWindowState.Minimized;
        
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.TopLevel = false;
            f.Size = gunaElipsePanel1.Size; // Set size of the new form to match PanelMain
            gunaElipsePanel1.Controls.Clear();
            gunaElipsePanel1.Controls.Add(f);
            f.Show();
            gunaElipsePanel1.SizeChanged += (s, ev) => { f.Size = gunaElipsePanel1.Size; };
            f.SizeChanged += (s, ev) => { gunaElipsePanel1.Size = f.Size; };


        }

        private void Orders_Button_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.TopLevel = false;
            f.Size = gunaElipsePanel1.Size; // Set size of the new form to match PanelMain
            gunaElipsePanel1.Controls.Clear();
            gunaElipsePanel1.Controls.Add(f);
            f.Show();
            gunaElipsePanel1.SizeChanged += (s, ev) => { f.Size = gunaElipsePanel1.Size; };
            f.SizeChanged += (s, ev) => { gunaElipsePanel1.Size = f.Size; };
        }

        private void Customers_Button_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.TopLevel = false;
            f.Size = gunaElipsePanel1.Size; // Set size of the new form to match PanelMain
            gunaElipsePanel1.Controls.Clear();
            gunaElipsePanel1.Controls.Add(f);
            f.Show();
            gunaElipsePanel1.SizeChanged += (s, ev) => { f.Size = gunaElipsePanel1.Size; };
            f.SizeChanged += (s, ev) => { gunaElipsePanel1.Size = f.Size; };
        }

        private void Statistics_Button_Click(object sender, EventArgs e)
        {
            Form5 f = new Form5();
            f.TopLevel = false;
            f.Size = gunaElipsePanel1.Size; // Set size of the new form to match PanelMain
            gunaElipsePanel1.Controls.Clear();
            gunaElipsePanel1.Controls.Add(f);
            f.Show();
            gunaElipsePanel1.SizeChanged += (s, ev) => { f.Size = gunaElipsePanel1.Size; };
            f.SizeChanged += (s, ev) => { gunaElipsePanel1.Size = f.Size; };
        }

        private void About_Button_Click(object sender, EventArgs e)
        {
            About f = new About();
            f.TopLevel = false;
            f.Size = gunaElipsePanel1.Size; // Set size of the new form to match PanelMain
            gunaElipsePanel1.Controls.Clear();
            gunaElipsePanel1.Controls.Add(f);
            f.Show();
            gunaElipsePanel1.SizeChanged += (s, ev) => { f.Size = gunaElipsePanel1.Size; };
            f.SizeChanged += (s, ev) => { gunaElipsePanel1.Size = f.Size; };
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
