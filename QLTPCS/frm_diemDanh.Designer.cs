﻿
namespace QLTPCS
{
    partial class frm_diemDanh
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
            this.txt_maNhanVien = new System.Windows.Forms.TextBox();
            this.txt_tenNhanVien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_diemDanh = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhân viên:";
            // 
            // txt_maNhanVien
            // 
            this.txt_maNhanVien.Location = new System.Drawing.Point(127, 130);
            this.txt_maNhanVien.Name = "txt_maNhanVien";
            this.txt_maNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txt_maNhanVien.TabIndex = 1;
            // 
            // txt_tenNhanVien
            // 
            this.txt_tenNhanVien.Location = new System.Drawing.Point(127, 182);
            this.txt_tenNhanVien.Name = "txt_tenNhanVien";
            this.txt_tenNhanVien.Size = new System.Drawing.Size(100, 20);
            this.txt_tenNhanVien.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên nhân viên:";
            // 
            // btn_diemDanh
            // 
            this.btn_diemDanh.Location = new System.Drawing.Point(262, 133);
            this.btn_diemDanh.Name = "btn_diemDanh";
            this.btn_diemDanh.Size = new System.Drawing.Size(75, 69);
            this.btn_diemDanh.TabIndex = 4;
            this.btn_diemDanh.Text = "Điểm danh";
            this.btn_diemDanh.UseVisualStyleBackColor = true;
            this.btn_diemDanh.Click += new System.EventHandler(this.btn_diemDanh_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(78, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Phiếu điểm danh";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frm_diemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_diemDanh);
            this.Controls.Add(this.txt_tenNhanVien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_maNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "frm_diemDanh";
            this.Text = "frm_diemDanh";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_maNhanVien;
        private System.Windows.Forms.TextBox txt_tenNhanVien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_diemDanh;
        private System.Windows.Forms.Label label3;
    }
}