﻿
namespace QLTPCS
{
    partial class frm_tkDiemDanh
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
            this.dgv_tkdd = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_thang = new System.Windows.Forms.TextBox();
            this.txt_nam = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_thongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkdd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tkdd
            // 
            this.dgv_tkdd.AllowUserToAddRows = false;
            this.dgv_tkdd.AllowUserToDeleteRows = false;
            this.dgv_tkdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tkdd.Location = new System.Drawing.Point(1, 2);
            this.dgv_tkdd.Name = "dgv_tkdd";
            this.dgv_tkdd.ReadOnly = true;
            this.dgv_tkdd.Size = new System.Drawing.Size(798, 275);
            this.dgv_tkdd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tháng:";
            // 
            // txt_thang
            // 
            this.txt_thang.Location = new System.Drawing.Point(53, 321);
            this.txt_thang.Name = "txt_thang";
            this.txt_thang.Size = new System.Drawing.Size(57, 20);
            this.txt_thang.TabIndex = 2;
            // 
            // txt_nam
            // 
            this.txt_nam.Location = new System.Drawing.Point(53, 369);
            this.txt_nam.Name = "txt_nam";
            this.txt_nam.Size = new System.Drawing.Size(57, 20);
            this.txt_nam.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 372);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm:";
            // 
            // btn_thongKe
            // 
            this.btn_thongKe.Location = new System.Drawing.Point(159, 367);
            this.btn_thongKe.Name = "btn_thongKe";
            this.btn_thongKe.Size = new System.Drawing.Size(75, 23);
            this.btn_thongKe.TabIndex = 5;
            this.btn_thongKe.Text = "Thống kê";
            this.btn_thongKe.UseVisualStyleBackColor = true;
            this.btn_thongKe.Click += new System.EventHandler(this.btn_thongKe_Click);
            // 
            // frm_tkDiemDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_thongKe);
            this.Controls.Add(this.txt_nam);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_thang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgv_tkdd);
            this.Name = "frm_tkDiemDanh";
            this.Text = "frm_tkDiemDanh";
            this.Load += new System.EventHandler(this.frm_tkDiemDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tkdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tkdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_thang;
        private System.Windows.Forms.TextBox txt_nam;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_thongKe;
    }
}