using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1_p78
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.IndexOf(textBox1.Text) >= 0)
            {
                listBox1.SelectedItem = textBox1.Text;
                textBox1.Clear();
            }
            else if (textBox1.Text.Length > 0)
            {
                listBox1.Items.Add(textBox1.Text);
                textBox1.Clear();
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnchon1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                listBox2.Items.Add(listBox1.Text);
            }  
        }

        private void btnchonnhieu_Click(object sender, EventArgs e)
        {
            foreach(string item in listBox1.SelectedItems)
            {
                listBox2.Items.Add(item);
            }
        }

        private void btnbo1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            }
        }

        private void btnbonhieu_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void btnlen_Click(object sender, EventArgs e)
        {
            int chon = listBox2.SelectedIndex;
            if (chon > 0)
            {
                string tam = listBox2.Items[chon].ToString();
                listBox2.Items[chon] = listBox2.Items[chon - 1];
                listBox2.Items[chon - 1] = tam;
                listBox2.SelectedItem = listBox2.Items[chon - 1];
            }
        }

        private void btnxuong_Click(object sender, EventArgs e)
        {
            int chon = listBox2.SelectedIndex;
            if (chon < listBox2.Items.Count - 1)
            {
                string tam = listBox2.Items[chon].ToString();
                listBox2.Items[chon] = listBox2.Items[chon + 1];
                listBox2.Items[chon + 1] = tam;
                listBox2.SelectedItem = listBox2.Items[chon + 1];
            }
        }
    }
}
