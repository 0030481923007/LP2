using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Collections;

namespace Atividade7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExericio3_Click(object sender, EventArgs e)
        {
            double[] Quantidade = new double[10];
            double[] Preco = new double[10];
            double Faturamento = 0;
            string valor = "";

            for (var x = 0; x < 10; x++)
            {
                valor = Interaction.InputBox("Quantidade de produtos:" + (x + 1),
                    "Entrada de dados");
                if (valor == "")
                {
                    break;
                }
                if (!double.TryParse(valor, out Quantidade[x]))
                {
                    MessageBox.Show("Insira um valor válido");
                    x--;

                }
                else
                {
                    valor = Interaction.InputBox("Entre com o dado na posição:" + (x + 1),
                        "Entrada de Dados");
                    if (valor == "")
                    {
                        break;
                    }
                    if (!double.TryParse(valor, out Preco[x]))
                    {
                        MessageBox.Show("Valor inválido");
                        x--;
                    }
                    else
                    {
                        Faturamento += Quantidade[x] * Preco[x];
                    }
                }
            }
            MessageBox.Show("Faturamento " + Faturamento.ToString("N2"));
        }

        private void btnExercicio1_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Digite um valor na posição:" + (x + 1),
                    "Entrada de Dados");
                if (valor == "")
                    break;

                if (int.TryParse(valor, out Vetor[x]))
                {
                    //auxiliar = auxiliar + "\n" + Vetor[x].ToString();
                    auxiliar = Vetor[x].ToString() + "\n" + auxiliar;
                }
                else
                {
                    MessageBox.Show("Número Inválido!");
                    x--;
                }
            }
            MessageBox.Show(auxiliar);
        }

        private void btnExericio2_Click(object sender, EventArgs e)
        {
            int[] Vetor = new int[20];
            string auxiliar = "";
            string valor = "";

            for (var x = 0; x < 20; x++)
            {
                valor = Interaction.InputBox("Preço do produto: " + (x + 1),
                    "Entrada de Dados");
                if (valor == "")
                    break;
                if (!int.TryParse(valor, out Vetor[x]))
                {
                    MessageBox.Show("Digite um número válido! !");
                    x--;
                }
            }

            Array.Reverse(Vetor);

            for (var x = 0; x < 20; x++)
                auxiliar = auxiliar + "\n" + Vetor[x];
            //   for (var x = 19; x >= 0; x--)
            //       auxiliar = auxiliar + "\n" + Vetor[x].ToString();

            MessageBox.Show(auxiliar);
        }

        private void btnExericio4_Click(object sender, EventArgs e)
        {
            string[] Alunos = { "Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo",
                "Jose", "Nelma", "Tobby" };

            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
                Total += Alunos[I].Length;
            MessageBox.Show(Total.ToString());

        }

        private void btnExericio5_Click(object sender, EventArgs e)
        {
            ArrayList alunos = new ArrayList(new string[] { "Ana","André","Débora","Fátima",
                "João","Janete","Otávio","Marcelo","Pedro","Thais"});
            string auxiliar = "";
            alunos.Remove("Otávio");
            foreach (String add in alunos)
                auxiliar += add + ",";
            MessageBox.Show(auxiliar);


        }

        private void btnExericio6_Click(object sender, EventArgs e)
        {
            string[] nome = new string[20];
            int[,] notas = new int[20, 3];
            int[] media = new int[20];
            string nomes = "";
            string auxiliar = "";
            int mediafinal = 0;

            for (var x = 0; x < 20; x++)
            {
                nomes = Interaction.InputBox("Digite o nome do aluno:" + (x + 1),
                     "Entrada de Dados");
                if (nomes == "")
                    break;
                else
                    nome[x] = nomes;
            }
            for (var y = 0; y < 20; y++)
            {
                for (var z = 0; z < 3; z++)
                {
                    auxiliar = Interaction.InputBox("Digite a nota:" + (z + 1),
                        "Entrada de Dados");
                    if (auxiliar == "")
                        break;
                    if (!int.TryParse(auxiliar, out notas[y, z]))
                    {
                        MessageBox.Show("Digite uma nota válida! !");
                    }
                }
            }
        for(var y = 0; y < 20; y++)
            {
                media[y] = (notas[y, 0] + notas[y, 1] + notas[y, 2])/3; 
            }
            foreach (string addnome in nome)
                nomes += addnome+":"+"\n";
            foreach (int addmedia in media)
                mediafinal = addmedia;
            MessageBox.Show(nomes + mediafinal);
        }
    }
}
