namespace BanHangSieuThi
{
    partial class Kho
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_khoatk = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_tim = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgv_hanghoa = new System.Windows.Forms.DataGridView();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_nhaphang = new System.Windows.Forms.Button();
            this.txt_soluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(271, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kho hàng";
            // 
            // txt_khoatk
            // 
            this.txt_khoatk.Location = new System.Drawing.Point(153, 71);
            this.txt_khoatk.Name = "txt_khoatk";
            this.txt_khoatk.Size = new System.Drawing.Size(177, 20);
            this.txt_khoatk.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tìm kiếm theo tên :";
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(349, 69);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(75, 23);
            this.btn_tim.TabIndex = 3;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(49, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Danh sách hàng hóa : ";
            // 
            // dgv_hanghoa
            // 
            this.dgv_hanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hanghoa.Location = new System.Drawing.Point(53, 183);
            this.dgv_hanghoa.Name = "dgv_hanghoa";
            this.dgv_hanghoa.Size = new System.Drawing.Size(551, 206);
            this.dgv_hanghoa.TabIndex = 5;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(529, 411);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(75, 23);
            this.btn_thoat.TabIndex = 6;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            // 
            // btn_nhaphang
            // 
            this.btn_nhaphang.Location = new System.Drawing.Point(349, 120);
            this.btn_nhaphang.Name = "btn_nhaphang";
            this.btn_nhaphang.Size = new System.Drawing.Size(75, 23);
            this.btn_nhaphang.TabIndex = 7;
            this.btn_nhaphang.Text = "Nhập hàng";
            this.btn_nhaphang.UseVisualStyleBackColor = true;
            // 
            // txt_soluong
            // 
            this.txt_soluong.Location = new System.Drawing.Point(229, 122);
            this.txt_soluong.Name = "txt_soluong";
            this.txt_soluong.Size = new System.Drawing.Size(101, 20);
            this.txt_soluong.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Số lượng sản phẩm nhập vào kho :";
            // 
            // Kho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_soluong);
            this.Controls.Add(this.btn_nhaphang);
            this.Controls.Add(this.btn_thoat);
            this.Controls.Add(this.dgv_hanghoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_tim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_khoatk);
            this.Controls.Add(this.label1);
            this.Name = "Kho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kho";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_khoatk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgv_hanghoa;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_nhaphang;
        private System.Windows.Forms.TextBox txt_soluong;
        private System.Windows.Forms.Label label4;
    }
}