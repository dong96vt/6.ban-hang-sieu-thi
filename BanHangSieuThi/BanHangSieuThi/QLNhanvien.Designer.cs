namespace BanHangSieuThi
{
    partial class QLNhanvien
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.bttk = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdnu = new System.Windows.Forms.RadioButton();
            this.rdnam = new System.Windows.Forms.RadioButton();
            this.btxoa = new System.Windows.Forms.Button();
            this.btsua = new System.Windows.Forms.Button();
            this.btthem = new System.Windows.Forms.Button();
            this.txtluong = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtadd = new System.Windows.Forms.TextBox();
            this.txthvt = new System.Windows.Forms.TextBox();
            this.txtmahienthi = new System.Windows.Forms.TextBox();
            this.txtma = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dg1 = new System.Windows.Forms.DataGridView();
            this.la = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dtns = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.Location = new System.Drawing.Point(83, 152);
            this.txtpass.Name = "txtpass";
            this.txtpass.Size = new System.Drawing.Size(184, 20);
            this.txtpass.TabIndex = 57;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(83, 126);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(184, 20);
            this.txtid.TabIndex = 56;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttk);
            this.groupBox2.Controls.Add(this.bttk);
            this.groupBox2.Location = new System.Drawing.Point(668, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TK mã";
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(33, 19);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(131, 20);
            this.txttk.TabIndex = 28;
            // 
            // bttk
            // 
            this.bttk.Location = new System.Drawing.Point(69, 58);
            this.bttk.Name = "bttk";
            this.bttk.Size = new System.Drawing.Size(75, 23);
            this.bttk.TabIndex = 29;
            this.bttk.Text = "Tìm kiếm";
            this.bttk.UseVisualStyleBackColor = true;
            this.bttk.Click += new System.EventHandler(this.bttk_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdnu);
            this.groupBox1.Controls.Add(this.rdnam);
            this.groupBox1.Location = new System.Drawing.Point(342, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 38);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gioi tinh";
            // 
            // rdnu
            // 
            this.rdnu.AutoSize = true;
            this.rdnu.Location = new System.Drawing.Point(97, 15);
            this.rdnu.Name = "rdnu";
            this.rdnu.Size = new System.Drawing.Size(39, 17);
            this.rdnu.TabIndex = 33;
            this.rdnu.Text = "Nữ";
            this.rdnu.UseVisualStyleBackColor = true;
            // 
            // rdnam
            // 
            this.rdnam.AutoSize = true;
            this.rdnam.Checked = true;
            this.rdnam.Location = new System.Drawing.Point(6, 15);
            this.rdnam.Name = "rdnam";
            this.rdnam.Size = new System.Drawing.Size(47, 17);
            this.rdnam.TabIndex = 19;
            this.rdnam.TabStop = true;
            this.rdnam.Text = "Nam";
            this.rdnam.UseVisualStyleBackColor = true;
            // 
            // btxoa
            // 
            this.btxoa.Location = new System.Drawing.Point(528, 178);
            this.btxoa.Name = "btxoa";
            this.btxoa.Size = new System.Drawing.Size(75, 23);
            this.btxoa.TabIndex = 53;
            this.btxoa.Text = "Xóa";
            this.btxoa.UseVisualStyleBackColor = true;
            this.btxoa.Click += new System.EventHandler(this.btxoa_Click);
            // 
            // btsua
            // 
            this.btsua.Location = new System.Drawing.Point(399, 178);
            this.btsua.Name = "btsua";
            this.btsua.Size = new System.Drawing.Size(75, 23);
            this.btsua.TabIndex = 52;
            this.btsua.Text = "Sửa";
            this.btsua.UseVisualStyleBackColor = true;
            this.btsua.Click += new System.EventHandler(this.btsua_Click);
            // 
            // btthem
            // 
            this.btthem.Location = new System.Drawing.Point(261, 178);
            this.btthem.Name = "btthem";
            this.btthem.Size = new System.Drawing.Size(75, 23);
            this.btthem.TabIndex = 51;
            this.btthem.Text = "Thêm";
            this.btthem.UseVisualStyleBackColor = true;
            this.btthem.Click += new System.EventHandler(this.btthem_Click);
            // 
            // txtluong
            // 
            this.txtluong.Location = new System.Drawing.Point(393, 70);
            this.txtluong.Name = "txtluong";
            this.txtluong.Size = new System.Drawing.Size(184, 20);
            this.txtluong.TabIndex = 50;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(393, 12);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(184, 20);
            this.txtdiachi.TabIndex = 48;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(393, 100);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(184, 20);
            this.txtchucvu.TabIndex = 47;
            // 
            // txtadd
            // 
            this.txtadd.Location = new System.Drawing.Point(83, 100);
            this.txtadd.Name = "txtadd";
            this.txtadd.Size = new System.Drawing.Size(184, 20);
            this.txtadd.TabIndex = 46;
            // 
            // txthvt
            // 
            this.txthvt.Location = new System.Drawing.Point(83, 70);
            this.txthvt.Name = "txthvt";
            this.txthvt.Size = new System.Drawing.Size(184, 20);
            this.txthvt.TabIndex = 45;
            // 
            // txtmahienthi
            // 
            this.txtmahienthi.Location = new System.Drawing.Point(83, 42);
            this.txtmahienthi.Name = "txtmahienthi";
            this.txtmahienthi.Size = new System.Drawing.Size(184, 20);
            this.txtmahienthi.TabIndex = 44;
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(83, 12);
            this.txtma.Name = "txtma";
            this.txtma.ReadOnly = true;
            this.txtma.Size = new System.Drawing.Size(184, 20);
            this.txtma.TabIndex = 43;
            this.txtma.TextChanged += new System.EventHandler(this.txtma_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(316, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Chức vụ ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(316, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Lương ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(316, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 40;
            this.label7.Text = "Ngày sinh ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(317, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Quê quán";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Họ tên ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Mã hiển thị ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Ma";
            // 
            // dg1
            // 
            this.dg1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dg1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg1.Location = new System.Drawing.Point(15, 207);
            this.dg1.Name = "dg1";
            this.dg1.Size = new System.Drawing.Size(893, 200);
            this.dg1.TabIndex = 58;
            this.dg1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dg1_CellContentClick);
            // 
            // la
            // 
            this.la.AutoSize = true;
            this.la.Location = new System.Drawing.Point(10, 129);
            this.la.Name = "la";
            this.la.Size = new System.Drawing.Size(17, 13);
            this.la.TabIndex = 59;
            this.la.Text = "IP";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 159);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(29, 13);
            this.label11.TabIndex = 63;
            this.label11.Text = "pass";
            // 
            // dtns
            // 
            this.dtns.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtns.Location = new System.Drawing.Point(393, 44);
            this.dtns.Name = "dtns";
            this.dtns.Size = new System.Drawing.Size(200, 20);
            this.dtns.TabIndex = 64;
            // 
            // QLNhanvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 409);
            this.Controls.Add(this.dtns);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.la);
            this.Controls.Add(this.dg1);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btxoa);
            this.Controls.Add(this.btsua);
            this.Controls.Add(this.btthem);
            this.Controls.Add(this.txtluong);
            this.Controls.Add(this.txtdiachi);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.txtadd);
            this.Controls.Add(this.txthvt);
            this.Controls.Add(this.txtmahienthi);
            this.Controls.Add(this.txtma);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QLNhanvien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhanvien";
            this.Load += new System.EventHandler(this.QLNhanvien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Button bttk;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdnu;
        private System.Windows.Forms.RadioButton rdnam;
        private System.Windows.Forms.Button btxoa;
        private System.Windows.Forms.Button btsua;
        private System.Windows.Forms.Button btthem;
        private System.Windows.Forms.TextBox txtluong;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtadd;
        private System.Windows.Forms.TextBox txthvt;
        private System.Windows.Forms.TextBox txtmahienthi;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dg1;
        private System.Windows.Forms.Label la;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker dtns;
    }
}