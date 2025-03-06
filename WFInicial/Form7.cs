using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class Form7 : Form
    {
        public string[] Produto = new string[6];
        public double[] Valor = new double[6];
        public int Contador = 0;

        public Form7()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Contador = Contador + 1;
            Produto[Contador - 1] = txtCaixa1.Text;
            Valor[Contador - 1] =
                Convert.ToDouble(txtCaixa2.Text);

            txtCaixa1.Text = "";
            txtCaixa2.Text = "";

            if (Contador == 6)
            {
                Double menor = Valor.Min();
                int posicao_menor = Array.IndexOf(Valor, menor);
                string mensagem = $"O produto mais barato é {Produto[posicao_menor]}" +
                    $" De valor {menor}";
                MessageBox.Show(mensagem);

            }
        }
    }
}