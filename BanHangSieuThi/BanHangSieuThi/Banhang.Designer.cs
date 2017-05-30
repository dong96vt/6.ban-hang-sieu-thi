<<<<<<< HEAD
﻿namespace BanHangSieuThi
{
    partial class Banhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Banhang));
            this.label1 = new System.Windows.Forms.Label();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ls_chon = new System.Windows.Forms.ListView();
            this.clma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txttienchu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtcmtnd = new System.Windows.Forms.TextBox();
            this.cbboqua = new System.Windows.Forms.CheckBox();
            this.cbb_khachquen = new System.Windows.Forms.ComboBox();
            this.cb_khachquen = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_manhanvien = new System.Windows.Forms.Label();
            this.rbt_nam = new System.Windows.Forms.RadioButton();
            this.rbt_nu = new System.Windows.Forms.RadioButton();
            this.rbt_khac = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            this.butmua = new System.Windows.Forms.Button();
            this.butquaylai = new System.Windows.Forms.Button();
            this.butthanhtoan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(129, 23);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(195, 20);
            this.txtkhoa.TabIndex = 5;
            this.txtkhoa.TextChanged += new System.EventHandler(this.txtkhoa_TextChanged);
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(400, 423);
            this.txttien.Name = "txttien";
            this.txttien.ReadOnly = true;
            this.txttien.Size = new System.Drawing.Size(275, 20);
            this.txttien.TabIndex = 6;
            this.txttien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hàng hóa đã mua";
            // 
            // ls_chon
            // 
            this.ls_chon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clma,
            this.clten,
            this.clsoluong,
            this.clgia});
            this.ls_chon.GridLines = true;
            this.ls_chon.Location = new System.Drawing.Point(339, 80);
            this.ls_chon.Name = "ls_chon";
            this.ls_chon.Size = new System.Drawing.Size(362, 329);
            this.ls_chon.TabIndex = 10;
            this.ls_chon.Tag = "";
            this.ls_chon.UseCompatibleStateImageBehavior = false;
            this.ls_chon.View = System.Windows.Forms.View.Details;
            // 
            // clma
            // 
            this.clma.DisplayIndex = 3;
            this.clma.Text = "Mã";
            this.clma.Width = 0;
            // 
            // clten
            // 
            this.clten.DisplayIndex = 0;
            this.clten.Text = "Sản Phẩm";
            this.clten.Width = 139;
            // 
            // clsoluong
            // 
            this.clsoluong.DisplayIndex = 1;
            this.clsoluong.Text = "SL";
            this.clsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clsoluong.Width = 46;
            // 
            // clgia
            // 
            this.clgia.DisplayIndex = 2;
            this.clgia.Text = "Giá /1 Sản phẩm";
            this.clgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clgia.Width = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thành chữ :";
            // 
            // txttienchu
            // 
            this.txttienchu.Location = new System.Drawing.Point(400, 461);
            this.txttienchu.Name = "txttienchu";
            this.txttienchu.ReadOnly = true;
            this.txttienchu.Size = new System.Drawing.Size(275, 20);
            this.txttienchu.TabIndex = 12;
            this.txttienchu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập tên hàng hóa :";
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.AllowUserToAddRows = false;
            this.dgvhanghoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Location = new System.Drawing.Point(12, 80);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.ReadOnly = true;
            this.dgvhanghoa.Size = new System.Drawing.Size(312, 328);
            this.dgvhanghoa.TabIndex = 15;
            // 
            // txtsoluong
            // 
            this.txtsoluong.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtsoluong.Location = new System.Drawing.Point(123, 441);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 22);
            this.txtsoluong.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(18, 444);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nhập số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "VND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(729, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Thông tin khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(755, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Họ tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(755, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "SĐT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(755, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Địa chỉ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(755, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Số CMTND:";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(836, 113);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(188, 20);
            this.txthoten.TabIndex = 25;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(836, 168);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(188, 20);
            this.txtsdt.TabIndex = 26;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(836, 231);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(188, 20);
            this.txtdiachi.TabIndex = 27;
            // 
            // txtcmtnd
            // 
            this.txtcmtnd.Location = new System.Drawing.Point(836, 291);
            this.txtcmtnd.Name = "txtcmtnd";
            this.txtcmtnd.Size = new System.Drawing.Size(188, 20);
            this.txtcmtnd.TabIndex = 28;
            // 
            // cbboqua
            // 
            this.cbboqua.AutoSize = true;
            this.cbboqua.Location = new System.Drawing.Point(913, 64);
            this.cbboqua.Name = "cbboqua";
            this.cbboqua.Size = new System.Drawing.Size(60, 17);
            this.cbboqua.TabIndex = 29;
            this.cbboqua.Text = "Bỏ qua";
            this.cbboqua.UseVisualStyleBackColor = true;
            this.cbboqua.CheckedChanged += new System.EventHandler(this.cbboqua_CheckedChanged);
            // 
            // cbb_khachquen
            // 
            this.cbb_khachquen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_khachquen.Enabled = false;
            this.cbb_khachquen.FormattingEnabled = true;
            this.cbb_khachquen.Location = new System.Drawing.Point(836, 390);
            this.cbb_khachquen.MaxDropDownItems = 100;
            this.cbb_khachquen.Name = "cbb_khachquen";
            this.cbb_khachquen.Size = new System.Drawing.Size(188, 21);
            this.cbb_khachquen.TabIndex = 30;
            this.cbb_khachquen.Tag = "Chọn khách hàng";
            this.cbb_khachquen.SelectedIndexChanged += new System.EventHandler(this.cbb_khachquen_SelectedIndexChanged);
            // 
            // cb_khachquen
            // 
            this.cb_khachquen.AutoSize = true;
            this.cb_khachquen.Location = new System.Drawing.Point(732, 392);
            this.cb_khachquen.Name = "cb_khachquen";
            this.cb_khachquen.Size = new System.Drawing.Size(84, 17);
            this.cb_khachquen.TabIndex = 31;
            this.cb_khachquen.Text = "Khách quen";
            this.cb_khachquen.UseVisualStyleBackColor = true;
            this.cb_khachquen.CheckedChanged += new System.EventHandler(this.cb_khachquen_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(851, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Mã nhân viên:";
            // 
            // lb_manhanvien
            // 
            this.lb_manhanvien.AutoSize = true;
            this.lb_manhanvien.Location = new System.Drawing.Point(932, 21);
            this.lb_manhanvien.Name = "lb_manhanvien";
            this.lb_manhanvien.Size = new System.Drawing.Size(16, 13);
            this.lb_manhanvien.TabIndex = 33;
            this.lb_manhanvien.Text = "-1";
            // 
            // rbt_nam
            // 
            this.rbt_nam.AutoSize = true;
            this.rbt_nam.Location = new System.Drawing.Point(836, 344);
            this.rbt_nam.Name = "rbt_nam";
            this.rbt_nam.Size = new System.Drawing.Size(47, 17);
            this.rbt_nam.TabIndex = 34;
            this.rbt_nam.TabStop = true;
            this.rbt_nam.Text = "Nam";
            this.rbt_nam.UseVisualStyleBackColor = true;
            // 
            // rbt_nu
            // 
            this.rbt_nu.AutoSize = true;
            this.rbt_nu.Location = new System.Drawing.Point(889, 344);
            this.rbt_nu.Name = "rbt_nu";
            this.rbt_nu.Size = new System.Drawing.Size(39, 17);
            this.rbt_nu.TabIndex = 35;
            this.rbt_nu.TabStop = true;
            this.rbt_nu.Text = "Nữ";
            this.rbt_nu.UseVisualStyleBackColor = true;
            // 
            // rbt_khac
            // 
            this.rbt_khac.AutoSize = true;
            this.rbt_khac.Location = new System.Drawing.Point(934, 344);
            this.rbt_khac.Name = "rbt_khac";
            this.rbt_khac.Size = new System.Drawing.Size(92, 17);
            this.rbt_khac.TabIndex = 36;
            this.rbt_khac.TabStop = true;
            this.rbt_khac.Text = "Giới tính khác";
            this.rbt_khac.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(755, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Giới tính:";
            // 
            // butmua
            // 
            this.butmua.BackgroundImage = global::BanHangSieuThi.Properties.Resources.Green_Buy;
            this.butmua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butmua.Location = new System.Drawing.Point(263, 426);
            this.butmua.Name = "butmua";
            this.butmua.Size = new System.Drawing.Size(61, 53);
            this.butmua.TabIndex = 16;
            this.butmua.UseVisualStyleBackColor = true;
            this.butmua.Click += new System.EventHandler(this.butmua_Click);
            // 
            // butquaylai
            // 
            this.butquaylai.BackgroundImage = global::BanHangSieuThi.Properties.Resources.Windows_Close_Program_icon__1_;
            this.butquaylai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butquaylai.Location = new System.Drawing.Point(758, 454);
            this.butquaylai.Name = "butquaylai";
            this.butquaylai.Size = new System.Drawing.Size(90, 80);
            this.butquaylai.TabIndex = 1;
            this.butquaylai.UseVisualStyleBackColor = true;
            this.butquaylai.Click += new System.EventHandler(this.butquaylai_Click);
            // 
            // butthanhtoan
            // 
            this.butthanhtoan.BackgroundImage = global::BanHangSieuThi.Properties.Resources.Money_icon;
            this.butthanhtoan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butthanhtoan.Location = new System.Drawing.Point(883, 454);
            this.butthanhtoan.Name = "butthanhtoan";
            this.butthanhtoan.Size = new System.Drawing.Size(90, 80);
            this.butthanhtoan.TabIndex = 0;
            this.butthanhtoan.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.butthanhtoan.UseVisualStyleBackColor = true;
            this.butthanhtoan.Click += new System.EventHandler(this.butthanhtoan_Click);
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanHangSieuThi.Properties.Resources.chinaz16;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1038, 546);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rbt_khac);
            this.Controls.Add(this.rbt_nu);
            this.Controls.Add(this.rbt_nam);
            this.Controls.Add(this.lb_manhanvien);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_khachquen);
            this.Controls.Add(this.cbb_khachquen);
            this.Controls.Add(this.cbboqua);
            this.Controls.Add(this.txtcmtnd);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.butmua);
            this.Controls.Add(this.dgvhanghoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttienchu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ls_chon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butquaylai);
            this.Controls.Add(this.butthanhtoan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Banhang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.Banhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butthanhtoan;
        private System.Windows.Forms.Button butquaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ls_chon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttienchu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.Button butmua;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader clten;
        private System.Windows.Forms.ColumnHeader clsoluong;
        private System.Windows.Forms.ColumnHeader clgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtcmtnd;
        private System.Windows.Forms.CheckBox cbboqua;
        private System.Windows.Forms.ComboBox cbb_khachquen;
        private System.Windows.Forms.CheckBox cb_khachquen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_manhanvien;
        private System.Windows.Forms.ColumnHeader clma;
        private System.Windows.Forms.RadioButton rbt_nam;
        private System.Windows.Forms.RadioButton rbt_nu;
        private System.Windows.Forms.RadioButton rbt_khac;
        private System.Windows.Forms.Label label15;
    }
=======
﻿namespace BanHangSieuThi
{
    partial class Banhang
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
            this.butthanhtoan = new System.Windows.Forms.Button();
            this.butquaylai = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ls_chon = new System.Windows.Forms.ListView();
            this.clma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clsoluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.txttienchu = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.butmua = new System.Windows.Forms.Button();
            this.txtsoluong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtcmtnd = new System.Windows.Forms.TextBox();
            this.cbboqua = new System.Windows.Forms.CheckBox();
            this.cbb_khachquen = new System.Windows.Forms.ComboBox();
            this.cb_khachquen = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lb_manhanvien = new System.Windows.Forms.Label();
            this.rbt_nam = new System.Windows.Forms.RadioButton();
            this.rbt_nu = new System.Windows.Forms.RadioButton();
            this.rbt_khac = new System.Windows.Forms.RadioButton();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // butthanhtoan
            // 
            this.butthanhtoan.Location = new System.Drawing.Point(560, 487);
            this.butthanhtoan.Name = "butthanhtoan";
            this.butthanhtoan.Size = new System.Drawing.Size(115, 33);
            this.butthanhtoan.TabIndex = 0;
            this.butthanhtoan.Text = "Thanh toán";
            this.butthanhtoan.UseVisualStyleBackColor = true;
            this.butthanhtoan.Click += new System.EventHandler(this.butthanhtoan_Click);
            // 
            // butquaylai
            // 
            this.butquaylai.Location = new System.Drawing.Point(400, 487);
            this.butquaylai.Name = "butquaylai";
            this.butquaylai.Size = new System.Drawing.Size(113, 33);
            this.butquaylai.TabIndex = 1;
            this.butquaylai.Text = "Quay lại";
            this.butquaylai.UseVisualStyleBackColor = true;
            this.butquaylai.Click += new System.EventHandler(this.butquaylai_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Danh sách hàng hóa";
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(129, 23);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(195, 20);
            this.txtkhoa.TabIndex = 5;
            this.txtkhoa.TextChanged += new System.EventHandler(this.txtkhoa_TextChanged);
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(400, 423);
            this.txttien.Name = "txttien";
            this.txttien.ReadOnly = true;
            this.txttien.Size = new System.Drawing.Size(275, 20);
            this.txttien.TabIndex = 6;
            this.txttien.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(336, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tổng tiền :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(681, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "VND";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(336, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Hàng hóa đã mua";
            // 
            // ls_chon
            // 
            this.ls_chon.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clma,
            this.clten,
            this.clsoluong,
            this.clgia});
            this.ls_chon.GridLines = true;
            this.ls_chon.Location = new System.Drawing.Point(339, 80);
            this.ls_chon.Name = "ls_chon";
            this.ls_chon.Size = new System.Drawing.Size(362, 329);
            this.ls_chon.TabIndex = 10;
            this.ls_chon.Tag = "";
            this.ls_chon.UseCompatibleStateImageBehavior = false;
            this.ls_chon.View = System.Windows.Forms.View.Details;
            // 
            // clma
            // 
            this.clma.DisplayIndex = 3;
            this.clma.Text = "Mã";
            this.clma.Width = 0;
            // 
            // clten
            // 
            this.clten.DisplayIndex = 0;
            this.clten.Text = "Sản Phẩm";
            this.clten.Width = 139;
            // 
            // clsoluong
            // 
            this.clsoluong.DisplayIndex = 1;
            this.clsoluong.Text = "SL";
            this.clsoluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clsoluong.Width = 46;
            // 
            // clgia
            // 
            this.clgia.DisplayIndex = 2;
            this.clgia.Text = "Giá /1 Sản phẩm";
            this.clgia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clgia.Width = 173;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 464);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Thành chữ :";
            // 
            // txttienchu
            // 
            this.txttienchu.Location = new System.Drawing.Point(400, 461);
            this.txttienchu.Name = "txttienchu";
            this.txttienchu.ReadOnly = true;
            this.txttienchu.Size = new System.Drawing.Size(275, 20);
            this.txttienchu.TabIndex = 12;
            this.txttienchu.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập tên hàng hóa :";
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.AllowUserToAddRows = false;
            this.dgvhanghoa.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Location = new System.Drawing.Point(12, 80);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.ReadOnly = true;
            this.dgvhanghoa.Size = new System.Drawing.Size(312, 328);
            this.dgvhanghoa.TabIndex = 15;
            // 
            // butmua
            // 
            this.butmua.Location = new System.Drawing.Point(223, 424);
            this.butmua.Name = "butmua";
            this.butmua.Size = new System.Drawing.Size(96, 23);
            this.butmua.TabIndex = 16;
            this.butmua.Text = "Mua";
            this.butmua.UseVisualStyleBackColor = true;
            this.butmua.Click += new System.EventHandler(this.butmua_Click);
            // 
            // txtsoluong
            // 
            this.txtsoluong.Location = new System.Drawing.Point(106, 426);
            this.txtsoluong.Name = "txtsoluong";
            this.txtsoluong.Size = new System.Drawing.Size(100, 20);
            this.txtsoluong.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 429);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Nhập số lượng:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(681, 464);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "VND";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(729, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(112, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Thông tin khách hàng";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(755, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Họ tên:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(755, 171);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "SĐT:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(755, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Địa chỉ:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(755, 294);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Số CMTND:";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(836, 113);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(188, 20);
            this.txthoten.TabIndex = 25;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(836, 168);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(188, 20);
            this.txtsdt.TabIndex = 26;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(836, 231);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(188, 20);
            this.txtdiachi.TabIndex = 27;
            // 
            // txtcmtnd
            // 
            this.txtcmtnd.Location = new System.Drawing.Point(836, 291);
            this.txtcmtnd.Name = "txtcmtnd";
            this.txtcmtnd.Size = new System.Drawing.Size(188, 20);
            this.txtcmtnd.TabIndex = 28;
            // 
            // cbboqua
            // 
            this.cbboqua.AutoSize = true;
            this.cbboqua.Location = new System.Drawing.Point(913, 64);
            this.cbboqua.Name = "cbboqua";
            this.cbboqua.Size = new System.Drawing.Size(60, 17);
            this.cbboqua.TabIndex = 29;
            this.cbboqua.Text = "Bỏ qua";
            this.cbboqua.UseVisualStyleBackColor = true;
            this.cbboqua.CheckedChanged += new System.EventHandler(this.cbboqua_CheckedChanged);
            // 
            // cbb_khachquen
            // 
            this.cbb_khachquen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_khachquen.Enabled = false;
            this.cbb_khachquen.FormattingEnabled = true;
            this.cbb_khachquen.Location = new System.Drawing.Point(836, 390);
            this.cbb_khachquen.MaxDropDownItems = 100;
            this.cbb_khachquen.Name = "cbb_khachquen";
            this.cbb_khachquen.Size = new System.Drawing.Size(188, 21);
            this.cbb_khachquen.TabIndex = 30;
            this.cbb_khachquen.Tag = "Chọn khách hàng";
            this.cbb_khachquen.SelectedIndexChanged += new System.EventHandler(this.cbb_khachquen_SelectedIndexChanged);
            // 
            // cb_khachquen
            // 
            this.cb_khachquen.AutoSize = true;
            this.cb_khachquen.Location = new System.Drawing.Point(732, 392);
            this.cb_khachquen.Name = "cb_khachquen";
            this.cb_khachquen.Size = new System.Drawing.Size(84, 17);
            this.cb_khachquen.TabIndex = 31;
            this.cb_khachquen.Text = "Khách quen";
            this.cb_khachquen.UseVisualStyleBackColor = true;
            this.cb_khachquen.CheckedChanged += new System.EventHandler(this.cb_khachquen_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(851, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Mã nhân viên:";
            // 
            // lb_manhanvien
            // 
            this.lb_manhanvien.AutoSize = true;
            this.lb_manhanvien.Location = new System.Drawing.Point(932, 21);
            this.lb_manhanvien.Name = "lb_manhanvien";
            this.lb_manhanvien.Size = new System.Drawing.Size(16, 13);
            this.lb_manhanvien.TabIndex = 33;
            this.lb_manhanvien.Text = "-1";
            // 
            // rbt_nam
            // 
            this.rbt_nam.AutoSize = true;
            this.rbt_nam.Location = new System.Drawing.Point(836, 344);
            this.rbt_nam.Name = "rbt_nam";
            this.rbt_nam.Size = new System.Drawing.Size(47, 17);
            this.rbt_nam.TabIndex = 34;
            this.rbt_nam.TabStop = true;
            this.rbt_nam.Text = "Nam";
            this.rbt_nam.UseVisualStyleBackColor = true;
            // 
            // rbt_nu
            // 
            this.rbt_nu.AutoSize = true;
            this.rbt_nu.Location = new System.Drawing.Point(889, 344);
            this.rbt_nu.Name = "rbt_nu";
            this.rbt_nu.Size = new System.Drawing.Size(39, 17);
            this.rbt_nu.TabIndex = 35;
            this.rbt_nu.TabStop = true;
            this.rbt_nu.Text = "Nữ";
            this.rbt_nu.UseVisualStyleBackColor = true;
            // 
            // rbt_khac
            // 
            this.rbt_khac.AutoSize = true;
            this.rbt_khac.Location = new System.Drawing.Point(934, 344);
            this.rbt_khac.Name = "rbt_khac";
            this.rbt_khac.Size = new System.Drawing.Size(92, 17);
            this.rbt_khac.TabIndex = 36;
            this.rbt_khac.TabStop = true;
            this.rbt_khac.Text = "Giới tính khác";
            this.rbt_khac.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(755, 346);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 13);
            this.label15.TabIndex = 37;
            this.label15.Text = "Giới tính:";
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 531);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.rbt_khac);
            this.Controls.Add(this.rbt_nu);
            this.Controls.Add(this.rbt_nam);
            this.Controls.Add(this.lb_manhanvien);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cb_khachquen);
            this.Controls.Add(this.cbb_khachquen);
            this.Controls.Add(this.cbboqua);
            this.Controls.Add(this.txtcmtnd);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtsdt);
            this.Controls.Add(this.txthoten);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtsoluong);
            this.Controls.Add(this.butmua);
            this.Controls.Add(this.dgvhanghoa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txttienchu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ls_chon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butquaylai);
            this.Controls.Add(this.butthanhtoan);
            this.Name = "Banhang";
            this.Text = "Bán hàng";
            this.Load += new System.EventHandler(this.Banhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butthanhtoan;
        private System.Windows.Forms.Button butquaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ls_chon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttienchu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.Button butmua;
        private System.Windows.Forms.TextBox txtsoluong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader clten;
        private System.Windows.Forms.ColumnHeader clsoluong;
        private System.Windows.Forms.ColumnHeader clgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtcmtnd;
        private System.Windows.Forms.CheckBox cbboqua;
        private System.Windows.Forms.ComboBox cbb_khachquen;
        private System.Windows.Forms.CheckBox cb_khachquen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lb_manhanvien;
        private System.Windows.Forms.ColumnHeader clma;
        private System.Windows.Forms.RadioButton rbt_nam;
        private System.Windows.Forms.RadioButton rbt_nu;
        private System.Windows.Forms.RadioButton rbt_khac;
        private System.Windows.Forms.Label label15;
    }
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
}