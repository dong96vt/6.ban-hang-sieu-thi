namespace BanHangSieuThi
{
    partial class Timhang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Timhang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_loai = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.lv_hanghoa = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_ten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_soluong = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_gia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cl_loai = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_min = new System.Windows.Forms.TextBox();
            this.txt_max = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(342, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tìm kiếm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(39, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhập yêu cầu tìm kiếm :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(40, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại hàng hóa :";
            // 
            // cbb_loai
            // 
            this.cbb_loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loai.FormattingEnabled = true;
            this.cbb_loai.Location = new System.Drawing.Point(160, 101);
            this.cbb_loai.MaxDropDownItems = 10;
            this.cbb_loai.Name = "cbb_loai";
            this.cbb_loai.Size = new System.Drawing.Size(145, 21);
            this.cbb_loai.TabIndex = 3;
            this.cbb_loai.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_loai_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.Location = new System.Drawing.Point(329, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mức giá (VNĐ) :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.Location = new System.Drawing.Point(111, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tên :";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(160, 145);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(145, 20);
            this.txt_ten.TabIndex = 6;
            this.txt_ten.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_loai_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(727, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "_________________________________________________________________________________" +
    "_______________________________________";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.Location = new System.Drawing.Point(296, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(230, 31);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kết quả tìm kiếm";
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(709, 523);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 12;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // lv_hanghoa
            // 
            this.lv_hanghoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.cl_ma,
            this.cl_ten,
            this.cl_soluong,
            this.cl_gia,
            this.cl_loai});
            this.lv_hanghoa.GridLines = true;
            this.lv_hanghoa.Location = new System.Drawing.Point(30, 244);
            this.lv_hanghoa.Name = "lv_hanghoa";
            this.lv_hanghoa.Size = new System.Drawing.Size(754, 273);
            this.lv_hanghoa.TabIndex = 13;
            this.lv_hanghoa.UseCompatibleStateImageBehavior = false;
            this.lv_hanghoa.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 0;
            // 
            // cl_ma
            // 
            this.cl_ma.Text = "Mã";
            this.cl_ma.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_ma.Width = 119;
            // 
            // cl_ten
            // 
            this.cl_ten.Text = "Tên";
            this.cl_ten.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_ten.Width = 186;
            // 
            // cl_soluong
            // 
            this.cl_soluong.Text = "Số lượng trong kho";
            this.cl_soluong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_soluong.Width = 137;
            // 
            // cl_gia
            // 
            this.cl_gia.Text = "Giá (VNĐ)";
            this.cl_gia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_gia.Width = 154;
            // 
            // cl_loai
            // 
            this.cl_loai.Text = "Loại mặt hàng";
            this.cl_loai.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cl_loai.Width = 133;
            // 
            // txt_min
            // 
            this.txt_min.Location = new System.Drawing.Point(450, 102);
            this.txt_min.Name = "txt_min";
            this.txt_min.Size = new System.Drawing.Size(111, 20);
            this.txt_min.TabIndex = 14;
            this.txt_min.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_loai_KeyDown);
            // 
            // txt_max
            // 
            this.txt_max.Location = new System.Drawing.Point(586, 102);
            this.txt_max.Name = "txt_max";
            this.txt_max.Size = new System.Drawing.Size(111, 20);
            this.txt_max.TabIndex = 15;
            this.txt_max.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbb_loai_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.Location = new System.Drawing.Point(567, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "-";
            // 
            // btn_tim
            // 
            this.btn_tim.BackgroundImage = global::BanHangSieuThi.Properties.Resources.ieframe_dll_52_131;
            this.btn_tim.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_tim.ImageKey = "(none)";
            this.btn_tim.Location = new System.Drawing.Point(722, 114);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(45, 42);
            this.btn_tim.TabIndex = 8;
            this.btn_tim.UseVisualStyleBackColor = true;
            this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
            // 
            // Timhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 556);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txt_max);
            this.Controls.Add(this.txt_min);
            this.Controls.Add(this.lv_hanghoa);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbb_loai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Timhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tìm kiếm hàng hóa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbb_loai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.ListView lv_hanghoa;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader cl_ma;
        private System.Windows.Forms.ColumnHeader cl_ten;
        private System.Windows.Forms.ColumnHeader cl_soluong;
        private System.Windows.Forms.ColumnHeader cl_gia;
        private System.Windows.Forms.ColumnHeader cl_loai;
        private System.Windows.Forms.TextBox txt_min;
        private System.Windows.Forms.TextBox txt_max;
        private System.Windows.Forms.Label label8;
    }
}