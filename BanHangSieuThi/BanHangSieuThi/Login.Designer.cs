<<<<<<< HEAD
﻿namespace BanHangSieuThi
{
    partial class frm_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_login));
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.but_dangnhap = new System.Windows.Forms.Button();
            this.but_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // txt_user
            // 
            this.txt_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_user.Location = new System.Drawing.Point(174, 27);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(180, 29);
            this.txt_user.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txt_pass.Location = new System.Drawing.Point(174, 69);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(180, 29);
            this.txt_pass.TabIndex = 5;
            // 
            // but_dangnhap
            // 
            this.but_dangnhap.BackgroundImage = global::BanHangSieuThi.Properties.Resources.Ok_icon;
            this.but_dangnhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.but_dangnhap.Location = new System.Drawing.Point(224, 123);
            this.but_dangnhap.Name = "but_dangnhap";
            this.but_dangnhap.Size = new System.Drawing.Size(92, 90);
            this.but_dangnhap.TabIndex = 3;
            this.but_dangnhap.UseVisualStyleBackColor = true;
            this.but_dangnhap.Click += new System.EventHandler(this.but_dangnhap_Click);
            // 
            // but_thoat
            // 
            this.but_thoat.BackColor = System.Drawing.SystemColors.Control;
            this.but_thoat.BackgroundImage = global::BanHangSieuThi.Properties.Resources.Windows_Turn_Off_icon;
            this.but_thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.but_thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.but_thoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.but_thoat.Location = new System.Drawing.Point(103, 123);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(92, 90);
            this.but_thoat.TabIndex = 2;
            this.but_thoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.but_thoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.but_thoat.UseVisualStyleBackColor = false;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // frm_login
            // 
            this.AcceptButton = this.but_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BanHangSieuThi.Properties.Resources.chinaz0;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(394, 239);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.but_dangnhap);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button but_dangnhap;
        private System.Windows.Forms.Button but_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
=======
﻿namespace BanHangSieuThi
{
    partial class frm_login
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.but_thoat = new System.Windows.Forms.Button();
            this.but_dangnhap = new System.Windows.Forms.Button();
            this.txt_user = new System.Windows.Forms.TextBox();
            this.txt_pass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu:";
            // 
            // but_thoat
            // 
            this.but_thoat.Location = new System.Drawing.Point(50, 168);
            this.but_thoat.Name = "but_thoat";
            this.but_thoat.Size = new System.Drawing.Size(119, 39);
            this.but_thoat.TabIndex = 2;
            this.but_thoat.Text = "Thoát";
            this.but_thoat.UseVisualStyleBackColor = true;
            this.but_thoat.Click += new System.EventHandler(this.but_thoat_Click);
            // 
            // but_dangnhap
            // 
            this.but_dangnhap.Location = new System.Drawing.Point(220, 168);
            this.but_dangnhap.Name = "but_dangnhap";
            this.but_dangnhap.Size = new System.Drawing.Size(119, 39);
            this.but_dangnhap.TabIndex = 3;
            this.but_dangnhap.Text = "Đăng nhập";
            this.but_dangnhap.UseVisualStyleBackColor = true;
            this.but_dangnhap.Click += new System.EventHandler(this.but_dangnhap_Click);
            // 
            // txt_user
            // 
            this.txt_user.Location = new System.Drawing.Point(146, 56);
            this.txt_user.Name = "txt_user";
            this.txt_user.Size = new System.Drawing.Size(193, 20);
            this.txt_user.TabIndex = 4;
            // 
            // txt_pass
            // 
            this.txt_pass.Location = new System.Drawing.Point(146, 109);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.PasswordChar = '*';
            this.txt_pass.Size = new System.Drawing.Size(193, 20);
            this.txt_pass.TabIndex = 5;
            // 
            // frm_login
            // 
            this.AcceptButton = this.but_dangnhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 261);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.txt_user);
            this.Controls.Add(this.but_dangnhap);
            this.Controls.Add(this.but_thoat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_login";
            this.Text = "Đăng nhập";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.TextBox txt_user;
        private System.Windows.Forms.Button but_dangnhap;
        private System.Windows.Forms.Button but_thoat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
>>>>>>> f1e85b1b0b1834a071756614e13c2def702f3266
}