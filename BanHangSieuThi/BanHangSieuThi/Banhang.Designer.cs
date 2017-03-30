namespace BanHangSieuThi
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
            this.buttimkiem = new System.Windows.Forms.Button();
            this.txtkhoa = new System.Windows.Forms.TextBox();
            this.txttien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ls_chon = new System.Windows.Forms.ListView();
            this.label5 = new System.Windows.Forms.Label();
            this.txttienchu = new System.Windows.Forms.TextBox();
            this.ls_hanghoa = new System.Windows.Forms.ListView();
            this.label6 = new System.Windows.Forms.Label();
            this.columma = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columten = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columgia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.butthanhtoan.Click += new System.EventHandler(this.button1_Click);
            // 
            // butquaylai
            // 
            this.butquaylai.Location = new System.Drawing.Point(400, 487);
            this.butquaylai.Name = "butquaylai";
            this.butquaylai.Size = new System.Drawing.Size(113, 33);
            this.butquaylai.TabIndex = 1;
            this.butquaylai.Text = "Quay lại";
            this.butquaylai.UseVisualStyleBackColor = true;
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
            // buttimkiem
            // 
            this.buttimkiem.Location = new System.Drawing.Point(420, 21);
            this.buttimkiem.Name = "buttimkiem";
            this.buttimkiem.Size = new System.Drawing.Size(76, 23);
            this.buttimkiem.TabIndex = 4;
            this.buttimkiem.Text = "Tìm kiếm";
            this.buttimkiem.UseVisualStyleBackColor = true;
            // 
            // txtkhoa
            // 
            this.txtkhoa.Location = new System.Drawing.Point(154, 23);
            this.txtkhoa.Name = "txtkhoa";
            this.txtkhoa.Size = new System.Drawing.Size(260, 20);
            this.txtkhoa.TabIndex = 5;
            // 
            // txttien
            // 
            this.txttien.Location = new System.Drawing.Point(400, 423);
            this.txttien.Name = "txttien";
            this.txttien.Size = new System.Drawing.Size(275, 20);
            this.txttien.TabIndex = 6;
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
            this.ls_chon.Location = new System.Drawing.Point(339, 80);
            this.ls_chon.Name = "ls_chon";
            this.ls_chon.Size = new System.Drawing.Size(362, 329);
            this.ls_chon.TabIndex = 10;
            this.ls_chon.UseCompatibleStateImageBehavior = false;
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
            this.txttienchu.Size = new System.Drawing.Size(275, 20);
            this.txttienchu.TabIndex = 12;
            // 
            // ls_hanghoa
            // 
            this.ls_hanghoa.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columma,
            this.columten,
            this.columgia});
            this.ls_hanghoa.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.ls_hanghoa.Location = new System.Drawing.Point(21, 80);
            this.ls_hanghoa.Name = "ls_hanghoa";
            this.ls_hanghoa.Size = new System.Drawing.Size(286, 329);
            this.ls_hanghoa.TabIndex = 13;
            this.ls_hanghoa.UseCompatibleStateImageBehavior = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nhập mã / tên hàng hóa :";
            // 
            // columma
            // 
            this.columma.Text = "Mã";
            // 
            // columten
            // 
            this.columten.Text = "Tên";
            // 
            // columgia
            // 
            this.columgia.Text = "Giá";
            // 
            // Banhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 531);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ls_hanghoa);
            this.Controls.Add(this.txttienchu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ls_chon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txttien);
            this.Controls.Add(this.txtkhoa);
            this.Controls.Add(this.buttimkiem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butquaylai);
            this.Controls.Add(this.butthanhtoan);
            this.Name = "Banhang";
            this.Text = "Bán hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butthanhtoan;
        private System.Windows.Forms.Button butquaylai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttimkiem;
        private System.Windows.Forms.TextBox txtkhoa;
        private System.Windows.Forms.TextBox txttien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView ls_chon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttienchu;
        private System.Windows.Forms.ListView ls_hanghoa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColumnHeader columma;
        private System.Windows.Forms.ColumnHeader columten;
        private System.Windows.Forms.ColumnHeader columgia;
    }
}