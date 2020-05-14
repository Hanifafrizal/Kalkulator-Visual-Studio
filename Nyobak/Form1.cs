using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nyobak
{
    public partial class Form1 : Form
    {
        public bool isResultClicked = false;
        public Form1()
        {
            InitializeComponent();
        }


        private void button_click(object sender, EventArgs e)
        {
            if (layer.Text == "0" ||isResultClicked==true) 
            {
                 layer.Clear();
                 isResultClicked = false;
            }

            Button button = (Button)sender;
            layer.Text = layer.Text + button.Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            String result = layer.Text;
            layer.Text = result.Substring(0, result.Length - 1);
        }

        private void operasi(object sender, EventArgs e)
        {
            if (isResultClicked == true)
            {
                layer.Text = "0";
                isResultClicked = false;
            }
            Button button = (Button)sender;
            layer.Text = layer.Text + button.Text;
        }

        private void hasil(object sender, EventArgs e)
        {
            isResultClicked = true;
            DataTable table = new DataTable();
            String expression = layer.Text;
            double result = Convert.ToDouble(table.Compute(expression, String.Empty));
            layer.Text = (result).ToString();
        }

        private void kosongkan(object sender, EventArgs e)
        {
            isResultClicked = false;
            layer.Text = "0";
        }

        private void layer_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
