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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            labelNama.Text = Akun.SetAkunNama;
            labelEmail.Text = Akun.SetAkunEmail;
            labelKelamin.Text = Akun.SetAkunKelamin;
            labelAlamat.Text = Akun.SetAkunAlamat;
        }

        private void labelEmail_Click(object sender, EventArgs e)
        {
            labelEmail.Text = Akun.SetAkunEmail;
        }

        private void labelNama_Click(object sender, EventArgs e)
        {
            labelNama.Text = Akun.SetAkunNama;
        }

        private void labelKelamin_Click(object sender, EventArgs e)
        {
            labelKelamin.Text = Akun.SetAkunKelamin;
        }

        private void LabelHarga_Click(object sender, EventArgs e)
        {
            
        }

        private void textBoxBeratBarang_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void labelAlamat_Click(object sender, EventArgs e)
        {
            labelAlamat.Text = Akun.SetAkunAlamat;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBox1_keyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }   
        }

        private void textBox2_leave(object sender, EventArgs e)
        {
            LabelHarga.Text = "Total Rp. ";
            LabelHarga.Text = LabelHarga.Text + ((double.Parse(textBox2.Text) * 5000).ToString());
        }

        private void buttonKirim_Click(object sender, EventArgs e)
        {
            if (textBoxBeratBarang.Text == "" || textBox1.Text == "" || textBox2.Text == "" || comboBoxWiayah.Text == "" || textBox4.Text == "")
            {
                label1.Visible = true;
            }

            else
            {
                labelEmailPenerima.Text = labelEmail.Text;
                labelRincianNamaPenerima.Text = labelNama.Text;
                labelRincianKelaminPenerima.Text = labelKelamin.Text;
                labelRincianAlamatPengrim.Text = labelAlamat.Text;
                labelNamaPenerima.Text = textBoxBeratBarang.Text;
                labelTeleponPenerima.Text = textBox1.Text;
                labelWilayahPenerima.Text = comboBoxWiayah.Text;
                labelAlamatPenerima.Text = textBox4.Text;
                labelRincianTotal.Text = labelRincianTotal.Text + textBox2.Text + " kg  x  Rp.5000";
                labelRincianTotalHarga.Text = LabelHarga.Text;

                panelRiwayat.Visible = true;
                panelKirim.Visible = false;
                panelRincian.Visible = true;
            }
        }
    }
}
