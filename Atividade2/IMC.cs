using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class IMC : Form
    {
        public IMC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            double pesoIdeal, altura, pesoAtual;


            if (Masculino.Checked)
            {
                
                
                
                double.TryParse(Altura.Text, out altura);
                double.TryParse(Peso.Text, out pesoAtual);
                pesoIdeal = (72.7 * altura) - 58;
                pesoIdeal = Math.Round(pesoIdeal, 1);


                if (pesoAtual < pesoIdeal)
                {
                    MessageBox.Show("Abaixo do Peso Ideal");
                }

                else if (pesoAtual > pesoIdeal)
                {
                    MessageBox.Show("Acima do Peso Ideal");
                }

                else
                {
                    MessageBox.Show("Congartulações - Peso Ideal");
                }
            }

            else if (Feminino.Checked)
            {
                double.TryParse(Altura.Text, out altura);
                double.TryParse(Peso.Text, out pesoAtual);
                pesoIdeal = (62.1 * altura) - 44.7;
                pesoIdeal = Math.Round(pesoIdeal, 1);

                if (pesoAtual < pesoIdeal)
                {
                    _ = MessageBox.Show("Abaixo do Peso Ideal");
                }

                else if (pesoAtual > pesoIdeal)
                {
                    MessageBox.Show("Acima do Peso Ideal");
                }

                else
                {
                    MessageBox.Show("Congartulações - Peso Ideal");
                }
            }

            else
            {
                MessageBox.Show("Selecione um Gênero");
            }
           
            
        }

        private void Altura_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void Peso_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void Altura_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void Peso_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void IMC_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Feminino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Masculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
