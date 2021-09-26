﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLTPCS
{
    public partial class frm_signup : Form
    {
        public frm_signup()
        {
            InitializeComponent();
        }
        /*
        private void checkTextFields()
        {
            string tk = txt_tenDangNhap.Text;
            string mk = txt_matKhau.Text;
            if (tk == "" || mk == "")
            {
                lb_tenDangNhap.Text = "Nhập tên đăng nhập !";
                lb_matKhau.Text = "Nhập mật khẩu !";
            }
        }
        */
        private void checkSignup()
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LJGMEJH;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
            conn.Open();
            string query = "select count (*) from TaiKhoan where TenDangNhap = @tk";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.Add(new SqlParameter("@tk", txt_tenDangNhap.Text));
            int sl = (int)cmd.ExecuteScalar();
            conn.Close();
            if(sl == 1)
            {
                //MessageBox.Show("Tên tài khoản đã tồn tại !!!");
                lb_tenDangNhap.Text = "Tên đăng nhập đã tồn tại !!!";
                txt_tenDangNhap.Focus();
            }
            else
            {

            }
        }
        private void btn_dangKi_Click(object sender, EventArgs e)
        {
            try { 
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-LJGMEJH;Initial Catalog=QLTPCS;User ID=sa;Password = 123456");
                conn.Open();
                string query = "insert into TaiKhoan values (@tk, @mk)";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@tk", txt_tenDangNhap.Text));
                cmd.Parameters.Add(new SqlParameter("@mk", txt_matKhau.Text));
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Đăng kí thành công !!!");
                
            }   
            catch(Exception ex)
            {
                //Console.WriteLine(ex.Message);
                checkSignup();
                //checkTextFields();
                MessageBox.Show("Đăng kí thất bại. Vui lòng thử lại !!!");
                
            }
        }

        private void btn_quayLai_Click(object sender, EventArgs e)
        {
            frm_login frm_Login = new frm_login();
            frm_Login.Show();
            this.Close();
        }

        private void frm_signup_Load(object sender, EventArgs e)
        {

        }
    }
}
