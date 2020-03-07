using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double verify1, verify2;

            if ((double.TryParse(raio.Text, out verify1) &&
                double.TryParse(altura.Text, out verify2)))
            {
                double calculo = Math.PI * Math.Pow(verify1,2)* verify2;
                volume.Text = calculo.ToString("N2");
            }
            else
                MessageBox.Show("Dados Inválidos!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            raio.Text = "";
            altura.Clear();
            volume.Text = String.Empty; //ou volume = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
