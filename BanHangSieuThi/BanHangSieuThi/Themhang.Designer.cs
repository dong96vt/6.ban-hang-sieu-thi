namespace BanHangSieuThi
{
    partial class Themhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Themhang));
            this.bntclear = new System.Windows.Forms.Button();
            this.bntThoat = new System.Windows.Forms.Button();
            this.dtHanghoa = new System.Windows.Forms.DataGridView();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.bntXoa = new System.Windows.Forms.Button();
            this.bntSua = new System.Windows.Forms.Button();
            this.bntThem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLoaiHang = new System.Windows.Forms.TextBox();
            this.txtMaHT = new System.Windows.Forms.TextBox();
            this.txtTenHH = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtMaHH = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtHanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // bntclear
            // 
            this.bntclear.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntclear.Location = new System.Drawing.Point(47, 232);
            this.bntclear.Name = "bntclear";
            this.bntclear.Size = new System.Drawing.Size(75, 23);
            this.bntclear.TabIndex = 45;
            this.bntclear.Text = "Clear";
            this.bntclear.UseVisualStyleBackColor = true;
            this.bntclear.Click += new System.EventHandler(this.bntclear_Click);
            // 
            // bntThoat
            // 
            this.bntThoat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntThoat.Location = new System.Drawing.Point(625, 232);
            this.bntThoat.Name = "bntThoat";
            this.bntThoat.Size = new System.Drawing.Size(75, 23);
            this.bntThoat.TabIndex = 44;
            this.bntThoat.Text = "Thoát";
            this.bntThoat.UseVisualStyleBackColor = true;
            this.bntThoat.Click += new System.EventHandler(this.bntThoat_Click);
            // 
            // dtHanghoa
            // 
            this.dtHanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtHanghoa.Location = new System.Drawing.Point(47, 282);
            this.dtHanghoa.Name = "dtHanghoa";
            this.dtHanghoa.Size = new System.Drawing.Size(653, 150);
            this.dtHanghoa.TabIndex = 43;
            this.dtHanghoa.SelectionChanged += new System.EventHandler(this.dtHanghoa_SelectionChanged);
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(172, 59);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(229, 20);
            this.txtTimkiem.TabIndex = 42;
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button5.Location = new System.Drawing.Point(49, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 41;
            this.button5.Text = "Tìm Kiếm ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // bntXoa
            // 
            this.bntXoa.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntXoa.Location = new System.Drawing.Point(495, 232);
            this.bntXoa.Name = "bntXoa";
            this.bntXoa.Size = new System.Drawing.Size(75, 23);
            this.bntXoa.TabIndex = 40;
            this.bntXoa.Text = "Xóa";
            this.bntXoa.UseVisualStyleBackColor = true;
            this.bntXoa.Click += new System.EventHandler(this.bntXoa_Click);
            // 
            // bntSua
            // 
            this.bntSua.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntSua.Location = new System.Drawing.Point(351, 232);
            this.bntSua.Name = "bntSua";
            this.bntSua.Size = new System.Drawing.Size(75, 23);
            this.bntSua.TabIndex = 39;
            this.bntSua.Text = "Sửa ";
            this.bntSua.UseVisualStyleBackColor = true;
            this.bntSua.Click += new System.EventHandler(this.bntSua_Click);
            // 
            // bntThem
            // 
            this.bntThem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bntThem.Location = new System.Drawing.Point(203, 232);
            this.bntThem.Name = "bntThem";
            this.bntThem.Size = new System.Drawing.Size(75, 23);
            this.bntThem.TabIndex = 38;
            this.bntThem.Text = "Thêm ";
            this.bntThem.UseVisualStyleBackColor = true;
            this.bntThem.Click += new System.EventHandler(this.bntThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(306, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = "QUẢN LÝ HÀNG HÓA ";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(749, 32);
            this.flowLayoutPanel1.TabIndex = 36;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(425, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 35;
            this.label6.Text = "Loại Hàng";
            // 
            // txtLoaiHang
            // 
            this.txtLoaiHang.Location = new System.Drawing.Point(551, 144);
            this.txtLoaiHang.Name = "txtLoaiHang";
            this.txtLoaiHang.Size = new System.Drawing.Size(149, 20);
            this.txtLoaiHang.TabIndex = 34;
            this.txtLoaiHang.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtLoaiHang_KeyDown);
            // 
            // txtMaHT
            // 
            this.txtMaHT.Location = new System.Drawing.Point(172, 142);
            this.txtMaHT.Name = "txtMaHT";
            this.txtMaHT.Size = new System.Drawing.Size(149, 20);
            this.txtMaHT.TabIndex = 33;
            this.txtMaHT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMaHT_KeyDown);
            // 
            // txtTenHH
            // 
            this.txtTenHH.Location = new System.Drawing.Point(172, 184);
            this.txtTenHH.Name = "txtTenHH";
            this.txtTenHH.Size = new System.Drawing.Size(149, 20);
            this.txtTenHH.TabIndex = 32;
            this.txtTenHH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTenHH_KeyDown);
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(551, 101);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(149, 20);
            this.txtSL.TabIndex = 31;
            this.txtSL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSL_KeyDown);
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(551, 184);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(149, 20);
            this.txtGia.TabIndex = 30;
            // 
            // txtMaHH
            // 
            this.txtMaHH.Location = new System.Drawing.Point(172, 105);
            this.txtMaHH.Name = "txtMaHH";
            this.txtMaHH.Size = new System.Drawing.Size(149, 20);
            this.txtMaHH.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(426, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Giá ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(425, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số Lượng ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(44, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 26;
            this.label3.Text = "Tên Hàng Hóa ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(46, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 16);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã Hiển Thị ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(46, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mã Hàng Hóa";
            // 
            // Themhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(749, 450);
            this.Controls.Add(this.bntclear);
            this.Controls.Add(this.bntThoat);
            this.Controls.Add(this.dtHanghoa);
            this.Controls.Add(this.txtTimkiem);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.bntXoa);
            this.Controls.Add(this.bntSua);
            this.Controls.Add(this.bntThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtLoaiHang);
            this.Controls.Add(this.txtMaHT);
            this.Controls.Add(this.txtTenHH);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtMaHH);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Themhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hàng hóa";
            this.Load += new System.EventHandler(this.Themhang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtHanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntclear;
        private System.Windows.Forms.Button bntThoat;
        private System.Windows.Forms.DataGridView dtHanghoa;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button bntXoa;
        private System.Windows.Forms.Button bntSua;
        private System.Windows.Forms.Button bntThem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtLoaiHang;
        private System.Windows.Forms.TextBox txtMaHT;
        private System.Windows.Forms.TextBox txtTenHH;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtMaHH;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}