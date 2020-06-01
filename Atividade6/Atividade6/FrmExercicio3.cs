using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void btnTeste_Click(object sender, EventArgs e)
        {
            if (txtTexto.Text.Length < 50)
            {
                string textSemEspaco = txtTexto.Text.Replace(" ", " ");
                string textInv = textSemEspaco;
                char[] arr = textInv.ToCharArray(); // joga a string para um array
                Array.Reverse(arr); // Inverte o array 
                textInv = "";
                foreach (char c in arr)
                    textInv = textInv + c.ToString();

                textInv = textInv.ToUpper();
                textSemEspaco = textSemEspaco.ToUpper();

                if(String.Compare(textSemEspaco, textInv, true) == 0) //true = casa e Casa são iguais
                    MessageBox.Show("É Palíndro");
                else
                    MessageBox.Show("Não é Palíndro");
            }
            else
                MessageBox.Show("Límite de caracteres: 50");

        }
    }
}
