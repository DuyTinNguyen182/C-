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

namespace QuanLyNhanVien_IT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection ketnoi;
        SqlDataAdapter bodocghi;
        int donghh;
        DataTable bangnv = new DataTable();
        void KetNoiDuLieu()
        {
            ketnoi = new SqlConnection();
            string chuoiketnoi = "Data Source= .;Initial Catalog=QuanLyNhanVien_LT;Integrated Security=True";
            ketnoi.ConnectionString = chuoiketnoi;
        }
        void LoadDuLieu()
        {
            KetNoiDuLieu();
            ketnoi.Open();
            string sql = "select * From NhanVien";
            bodocghi = new SqlDataAdapter(sql, ketnoi);
            bodocghi.Fill(bangnv);
            ketnoi.Close();
            dgvNhanVien.DataSource = bangnv;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbDiaChi.SelectedIndex = 0;
            cmbGT.SelectedIndex = 2;
            LoadDuLieu();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
                MessageBox.Show("Mã nhân viên không được để trống");

            else
            {                
                ketnoi.Open();         
                String sql1 = "select * from NhanVien where MaNV = '" + txtMaNV.Text + "'";
                SqlCommand cmd = new SqlCommand(sql1, ketnoi);
                SqlDataReader dr = cmd.ExecuteReader();
                String manv = dr["MaNV"].ToString();
                if (txtMaNV.Text == manv)
                {
                    MessageBox.Show("Đã tồn tại");
                    ketnoi.Close();
                }
                else
                {
                    ketnoi.Open();
                    String sql = "insert into NhanVien Values('" + txtMaNV.Text + "',N'" + txtHoTen.Text + "','" + txtNamSinh.Text + "',N'" + cmbGT.Text + "',N'" + cmbDiaChi.Text + "','" + txtDienThoai.Text + "')";
                    SqlCommand cmd1 = new SqlCommand(sql, ketnoi);
                    cmd1.ExecuteNonQuery();
                    ketnoi.Close();
                    bangnv.Clear();
                    LoadDuLieu();
                }                
                
            }
        }

        private void dgvNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            donghh = e.RowIndex;
            if (donghh >= 0)
            {
                txtMaNV.Text = bangnv.Rows[donghh]["MaNV"].ToString();
                txtHoTen.Text = bangnv.Rows[donghh]["HoTen"].ToString();
                txtNamSinh.Text = bangnv.Rows[donghh]["NamSinh"].ToString();
                cmbGT.Text = bangnv.Rows[donghh]["GioiTinh"].ToString();
                cmbDiaChi.Text = bangnv.Rows[donghh]["DiaChi"].ToString();
                txtDienThoai.Text = bangnv.Rows[donghh]["DienThoai"].ToString();
                txtMaNV.Enabled = false;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "DELETE from NhanVien where MaNV = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();//Không có giá trị trả về
            ketnoi.Close();
            bangnv.Clear();
            LoadDuLieu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "Update NhanVien set HoTen = N'" + txtHoTen.Text + "',NamSinh='" + txtNamSinh.Text + "',GioiTinh =N'" + cmbGT.Text + "',DiaChi =N'" + cmbDiaChi.Text + "',DienThoai='" + txtDienThoai.Text + "'Where MaNV='" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            cmd.ExecuteNonQuery();
            ketnoi.Close();
            bangnv.Clear();
            LoadDuLieu();
        }

        private void btnMa_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "select * from NhanVien where MaNV = '" + txtMaNV.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            SqlDataReader dr = cmd.ExecuteReader();
            String manv, ht, gt, dc, dt;
            int ns;
            if (dr.Read())
            {
                manv = dr["MaNV"].ToString();
                ht = dr["HoTen"].ToString();
                gt = dr["GioiTinh"].ToString();
                dc = dr["DiaChi"].ToString();
                dt = dr["DienThoai"].ToString();
                ns = (int)dr["NamSinh"];
                String msg = String.Format("Mã NV: {0}\n Tên NV: {1}\n Giới Tính: {2}\n Năm Sinh: {3}\n Địa Chỉ: {4}\n Điện Thoại: {5}", manv, ht, gt, ns, dc, dt);
                MessageBox.Show(msg, "Thông báo");
            }
            else
                MessageBox.Show("Không tìm thấy!");
            ketnoi.Close();
        }

        private void btnSL_Click(object sender, EventArgs e)
        {
            ketnoi.Open();
            String sql = "Select count(*) From NhanVien";
            SqlCommand cmd = new SqlCommand(sql, ketnoi);
            int count = (int)cmd.ExecuteScalar();
            String msg = String.Format("Số lượng nhân viên là: {0}", count);
            MessageBox.Show(msg, "Thông báo");
            ketnoi.Close();
        }
    }
}
