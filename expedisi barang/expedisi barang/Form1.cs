using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace expedisi_barang
{
    public partial class Akun : Form
    {
        public static string SetAkunNama, SetAkunEmail, SetAkunKelamin, SetAkunAlamat;
        public Akun()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Akun_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "Masukan Email Anda")
            {
                textBox2.SelectionStart = 0;
                textBox2.SelectionLength = textBox2.Text.Length;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "Masukan Alamat Anda")
            {
                textBox3.SelectionStart = 0;
                textBox3.SelectionLength = textBox3.Text.Length;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || checkBox1.Checked == false)
                label6.Visible = true;
            else if (textBox1.Text == "Masukan Nama Anda" || textBox2.Text == "Masukan Email Anda" || textBox3.Text == "Masukan Alamat Anda")
                label6.Visible = true;
            else if (comboBox1.Text == null)
                label6.Visible = true;
            else
            {
                SetAkunNama = textBox1.Text;
                SetAkunEmail = textBox2.Text;
                SetAkunKelamin = comboBox1.Text;
                SetAkunAlamat = textBox3.Text;
                var formbaru = new Menu();
                formbaru.Show();
                this.Hide();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
