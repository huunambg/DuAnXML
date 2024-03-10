namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.txt_timkiemhd = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_hoadon = new System.Windows.Forms.DataGridView();
            this.dgv_chitiethoadon = new System.Windows.Forms.DataGridView();
            this.btn_xoacthd = new System.Windows.Forms.Button();
            this.btn_suacthd = new System.Windows.Forms.Button();
            this.btn_themcthd = new System.Windows.Forms.Button();
            this.btn_xoahd = new System.Windows.Forms.Button();
            this.btn_suahd = new System.Windows.Forms.Button();
            this.btn_themhd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_mahd = new Guna.UI.WinForms.GunaTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_giaban = new Guna.UI.WinForms.GunaTextBox();
            this.txt_soluong = new Guna.UI.WinForms.GunaTextBox();
            this.txt_tensp = new Guna.UI.WinForms.GunaTextBox();
            this.txt_cthd = new Guna.UI.WinForms.GunaTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_thanhtien = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaComboBox1 = new Guna.UI.WinForms.GunaComboBox();
            this.gunaComboBox2 = new Guna.UI.WinForms.GunaComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_timkiem.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_timkiem.Location = new System.Drawing.Point(1233, 9);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(127, 34);
            this.btn_timkiem.TabIndex = 36;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = false;
            // 
            // txt_timkiemhd
            // 
            this.txt_timkiemhd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_timkiemhd.BackColor = System.Drawing.Color.Transparent;
            this.txt_timkiemhd.BaseColor = System.Drawing.Color.White;
            this.txt_timkiemhd.BorderColor = System.Drawing.Color.Silver;
            this.txt_timkiemhd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_timkiemhd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_timkiemhd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_timkiemhd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_timkiemhd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_timkiemhd.Location = new System.Drawing.Point(1030, 9);
            this.txt_timkiemhd.Name = "txt_timkiemhd";
            this.txt_timkiemhd.PasswordChar = '\0';
            this.txt_timkiemhd.Radius = 10;
            this.txt_timkiemhd.Size = new System.Drawing.Size(197, 34);
            this.txt_timkiemhd.TabIndex = 32;
            // 
            // dgv_hoadon
            // 
            this.dgv_hoadon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_hoadon.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_hoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hoadon.Location = new System.Drawing.Point(348, 49);
            this.dgv_hoadon.Name = "dgv_hoadon";
            this.dgv_hoadon.RowHeadersWidth = 51;
            this.dgv_hoadon.RowTemplate.Height = 24;
            this.dgv_hoadon.Size = new System.Drawing.Size(1012, 319);
            this.dgv_hoadon.TabIndex = 31;
            this.dgv_hoadon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_hoadon_CellClick);
            // 
            // dgv_chitiethoadon
            // 
            this.dgv_chitiethoadon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_chitiethoadon.BackgroundColor = System.Drawing.Color.RosyBrown;
            this.dgv_chitiethoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_chitiethoadon.Location = new System.Drawing.Point(348, 374);
            this.dgv_chitiethoadon.Name = "dgv_chitiethoadon";
            this.dgv_chitiethoadon.RowHeadersWidth = 51;
            this.dgv_chitiethoadon.RowTemplate.Height = 24;
            this.dgv_chitiethoadon.Size = new System.Drawing.Size(1012, 314);
            this.dgv_chitiethoadon.TabIndex = 49;
            // 
            // btn_xoacthd
            // 
            this.btn_xoacthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoacthd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_xoacthd.Location = new System.Drawing.Point(209, 636);
            this.btn_xoacthd.Name = "btn_xoacthd";
            this.btn_xoacthd.Size = new System.Drawing.Size(75, 52);
            this.btn_xoacthd.TabIndex = 52;
            this.btn_xoacthd.Text = "Xoá";
            this.btn_xoacthd.UseVisualStyleBackColor = false;
            // 
            // btn_suacthd
            // 
            this.btn_suacthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_suacthd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_suacthd.Location = new System.Drawing.Point(128, 636);
            this.btn_suacthd.Name = "btn_suacthd";
            this.btn_suacthd.Size = new System.Drawing.Size(75, 52);
            this.btn_suacthd.TabIndex = 51;
            this.btn_suacthd.Text = "Sửa";
            this.btn_suacthd.UseVisualStyleBackColor = false;
            // 
            // btn_themcthd
            // 
            this.btn_themcthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_themcthd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_themcthd.Location = new System.Drawing.Point(47, 636);
            this.btn_themcthd.Name = "btn_themcthd";
            this.btn_themcthd.Size = new System.Drawing.Size(75, 52);
            this.btn_themcthd.TabIndex = 50;
            this.btn_themcthd.Text = "Thêm";
            this.btn_themcthd.UseVisualStyleBackColor = false;
            // 
            // btn_xoahd
            // 
            this.btn_xoahd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_xoahd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_xoahd.Location = new System.Drawing.Point(209, 307);
            this.btn_xoahd.Name = "btn_xoahd";
            this.btn_xoahd.Size = new System.Drawing.Size(75, 52);
            this.btn_xoahd.TabIndex = 55;
            this.btn_xoahd.Text = "Xoá";
            this.btn_xoahd.UseVisualStyleBackColor = false;
            // 
            // btn_suahd
            // 
            this.btn_suahd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_suahd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_suahd.Location = new System.Drawing.Point(128, 307);
            this.btn_suahd.Name = "btn_suahd";
            this.btn_suahd.Size = new System.Drawing.Size(75, 52);
            this.btn_suahd.TabIndex = 54;
            this.btn_suahd.Text = "Sửa";
            this.btn_suahd.UseVisualStyleBackColor = false;
            // 
            // btn_themhd
            // 
            this.btn_themhd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btn_themhd.BackColor = System.Drawing.Color.RosyBrown;
            this.btn_themhd.Location = new System.Drawing.Point(47, 307);
            this.btn_themhd.Name = "btn_themhd";
            this.btn_themhd.Size = new System.Drawing.Size(75, 52);
            this.btn_themhd.TabIndex = 53;
            this.btn_themhd.Text = "Thêm";
            this.btn_themhd.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 16);
            this.label4.TabIndex = 65;
            this.label4.Text = "Mã khách hàng";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 16);
            this.label3.TabIndex = 64;
            this.label3.Text = "Mã nhân viên";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 63;
            this.label2.Text = "Ngày đặt";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 62;
            this.label1.Text = "Mã hoá đơn";
            // 
            // txt_mahd
            // 
            this.txt_mahd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_mahd.BackColor = System.Drawing.Color.Transparent;
            this.txt_mahd.BaseColor = System.Drawing.Color.White;
            this.txt_mahd.BorderColor = System.Drawing.Color.Silver;
            this.txt_mahd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_mahd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_mahd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_mahd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_mahd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_mahd.Location = new System.Drawing.Point(128, 49);
            this.txt_mahd.Name = "txt_mahd";
            this.txt_mahd.PasswordChar = '\0';
            this.txt_mahd.Radius = 10;
            this.txt_mahd.Size = new System.Drawing.Size(197, 34);
            this.txt_mahd.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 513);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 16);
            this.label9.TabIndex = 77;
            this.label9.Text = "Giá bán";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 473);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 16);
            this.label10.TabIndex = 76;
            this.label10.Text = "Số lượng";
            // 
            // txt_giaban
            // 
            this.txt_giaban.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_giaban.BackColor = System.Drawing.Color.Transparent;
            this.txt_giaban.BaseColor = System.Drawing.Color.White;
            this.txt_giaban.BorderColor = System.Drawing.Color.Silver;
            this.txt_giaban.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_giaban.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_giaban.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_giaban.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_giaban.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_giaban.Location = new System.Drawing.Point(128, 504);
            this.txt_giaban.Name = "txt_giaban";
            this.txt_giaban.PasswordChar = '\0';
            this.txt_giaban.Radius = 10;
            this.txt_giaban.Size = new System.Drawing.Size(197, 34);
            this.txt_giaban.TabIndex = 71;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_soluong.BackColor = System.Drawing.Color.Transparent;
            this.txt_soluong.BaseColor = System.Drawing.Color.White;
            this.txt_soluong.BorderColor = System.Drawing.Color.Silver;
            this.txt_soluong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_soluong.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_soluong.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_soluong.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_soluong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_soluong.Location = new System.Drawing.Point(128, 464);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.PasswordChar = '\0';
            this.txt_soluong.Radius = 10;
            this.txt_soluong.Size = new System.Drawing.Size(197, 34);
            this.txt_soluong.TabIndex = 70;
            // 
            // txt_tensp
            // 
            this.txt_tensp.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_tensp.BackColor = System.Drawing.Color.Transparent;
            this.txt_tensp.BaseColor = System.Drawing.Color.White;
            this.txt_tensp.BorderColor = System.Drawing.Color.Silver;
            this.txt_tensp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_tensp.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_tensp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_tensp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_tensp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_tensp.Location = new System.Drawing.Point(128, 424);
            this.txt_tensp.Name = "txt_tensp";
            this.txt_tensp.PasswordChar = '\0';
            this.txt_tensp.Radius = 10;
            this.txt_tensp.Size = new System.Drawing.Size(197, 34);
            this.txt_tensp.TabIndex = 69;
            // 
            // txt_cthd
            // 
            this.txt_cthd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_cthd.BackColor = System.Drawing.Color.Transparent;
            this.txt_cthd.BaseColor = System.Drawing.Color.White;
            this.txt_cthd.BorderColor = System.Drawing.Color.Silver;
            this.txt_cthd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_cthd.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_cthd.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_cthd.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_cthd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_cthd.Location = new System.Drawing.Point(128, 384);
            this.txt_cthd.Name = "txt_cthd";
            this.txt_cthd.PasswordChar = '\0';
            this.txt_cthd.Radius = 10;
            this.txt_cthd.Size = new System.Drawing.Size(197, 34);
            this.txt_cthd.TabIndex = 68;
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 393);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 16);
            this.label12.TabIndex = 74;
            this.label12.Text = "Mã CTHĐ";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 433);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 16);
            this.label11.TabIndex = 75;
            this.label11.Text = "Tên sản phẩm";
            // 
            // txt_thanhtien
            // 
            this.txt_thanhtien.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txt_thanhtien.BackColor = System.Drawing.Color.Transparent;
            this.txt_thanhtien.BaseColor = System.Drawing.Color.White;
            this.txt_thanhtien.BorderColor = System.Drawing.Color.Silver;
            this.txt_thanhtien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_thanhtien.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_thanhtien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_thanhtien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_thanhtien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_thanhtien.Location = new System.Drawing.Point(128, 544);
            this.txt_thanhtien.Name = "txt_thanhtien";
            this.txt_thanhtien.PasswordChar = '\0';
            this.txt_thanhtien.Radius = 10;
            this.txt_thanhtien.Size = new System.Drawing.Size(197, 34);
            this.txt_thanhtien.TabIndex = 72;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 78;
            this.label8.Text = "Thành tiền";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(128, 93);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(197, 30);
            this.gunaDateTimePicker1.TabIndex = 80;
            this.gunaDateTimePicker1.Text = "07/03/2024";
            this.gunaDateTimePicker1.Value = new System.DateTime(2024, 3, 7, 18, 9, 13, 272);
            // 
            // gunaComboBox1
            // 
            this.gunaComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox1.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox1.FormattingEnabled = true;
            this.gunaComboBox1.Items.AddRange(new object[] {
            "Nguyễn Văn A",
            "Nguyễn Văn B",
            "Nguyễn Văn C"});
            this.gunaComboBox1.Location = new System.Drawing.Point(128, 129);
            this.gunaComboBox1.Name = "gunaComboBox1";
            this.gunaComboBox1.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox1.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox1.Size = new System.Drawing.Size(197, 31);
            this.gunaComboBox1.TabIndex = 81;
            // 
            // gunaComboBox2
            // 
            this.gunaComboBox2.BackColor = System.Drawing.Color.Transparent;
            this.gunaComboBox2.BaseColor = System.Drawing.Color.White;
            this.gunaComboBox2.BorderColor = System.Drawing.Color.Silver;
            this.gunaComboBox2.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.gunaComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gunaComboBox2.FocusedColor = System.Drawing.Color.Empty;
            this.gunaComboBox2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.gunaComboBox2.ForeColor = System.Drawing.Color.Black;
            this.gunaComboBox2.FormattingEnabled = true;
            this.gunaComboBox2.Location = new System.Drawing.Point(128, 170);
            this.gunaComboBox2.Name = "gunaComboBox2";
            this.gunaComboBox2.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaComboBox2.OnHoverItemForeColor = System.Drawing.Color.White;
            this.gunaComboBox2.Size = new System.Drawing.Size(197, 31);
            this.gunaComboBox2.TabIndex = 82;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1372, 700);
            this.Controls.Add(this.gunaComboBox2);
            this.Controls.Add(this.gunaComboBox1);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_thanhtien);
            this.Controls.Add(this.txt_giaban);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.txt_tensp);
            this.Controls.Add(this.txt_cthd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mahd);
            this.Controls.Add(this.btn_xoahd);
            this.Controls.Add(this.btn_suahd);
            this.Controls.Add(this.btn_themhd);
            this.Controls.Add(this.btn_xoacthd);
            this.Controls.Add(this.btn_suacthd);
            this.Controls.Add(this.btn_themcthd);
            this.Controls.Add(this.dgv_chitiethoadon);
            this.Controls.Add(this.btn_timkiem);
            this.Controls.Add(this.txt_timkiemhd);
            this.Controls.Add(this.dgv_hoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hoadon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_chitiethoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_timkiem;
        private Guna.UI.WinForms.GunaTextBox txt_timkiemhd;
        private System.Windows.Forms.DataGridView dgv_hoadon;
        private System.Windows.Forms.DataGridView dgv_chitiethoadon;
        private System.Windows.Forms.Button btn_xoacthd;
        private System.Windows.Forms.Button btn_suacthd;
        private System.Windows.Forms.Button btn_themcthd;
        private System.Windows.Forms.Button btn_xoahd;
        private System.Windows.Forms.Button btn_suahd;
        private System.Windows.Forms.Button btn_themhd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_mahd;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Guna.UI.WinForms.GunaTextBox txt_giaban;
        private Guna.UI.WinForms.GunaTextBox txt_soluong;
        private Guna.UI.WinForms.GunaTextBox txt_tensp;
        private Guna.UI.WinForms.GunaTextBox txt_cthd;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private Guna.UI.WinForms.GunaTextBox txt_thanhtien;
        private System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox1;
        private Guna.UI.WinForms.GunaComboBox gunaComboBox2;
    }
}