using System;
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
    }
}
