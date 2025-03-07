using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFInicial
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double resultado,Numero1, Numero2 = 0;
            bool ehValidoNum1 = double.TryParse(txtNumero1.Text, out Numero1);
            bool ehValidoNum2 = double.TryParse(txtNumero2.Text, out Numero2);

            if(!ehValidoNum1 || !ehValidoNum2)
            {
                MessageBox.Show("Os valores digitados não são um número",
                    "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rdbSoma.Checked)
            {
                resultado = Numero1 + Numero2;
                string mensagem = $"A soma de {Numero1} + {Numero2} = {resultado}";
                MessageBox.Show(mensagem, "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (rdbSubtracao.Checked == true)
            {
                resultado = Numero1 - Numero2;
                string mensagem = $"A subtração de {Numero1} - {Numero2} = {resultado}";
                MessageBox.Show(mensagem, "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rdbMutiplicacao.Checked == true)
            {
                resultado = Numero1 * Numero2;
                string mensagem = $"A multiplicação de {Numero1} * {Numero2} = {resultado}";
                MessageBox.Show(mensagem, "info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           else if(rdbDivisao.Checked == true)
            {
                if (Numero2 == 0)
                {
                    MessageBox.Show("O denominador não pode ser zero!",
                        "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    resultado = Numero1 / Numero2;
                    string mensagem = $"A divisão de {Numero1} / {Numero2} = {resultado}";
                    MessageBox.Show(mensagem, "info",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else if(rdbPotenciacao.Checked == true)
            {
                resultado = Math.Pow(Numero1, Numero2);
                string mensagem = $"A potência de {Numero1} ^ {Numero2} = {resultado:F2}";
                MessageBox.Show(mensagem, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if(rdbRadiciacao.Checked == true)
            {
                if(Numero2 == 0 )
                    resultado = 1;
                else 
                    resultado = Math.Pow(Numero1, (1 / Numero2));


                string mensagem = $"A raiz de {Numero1} ^ {Numero2} = {resultado:f2}";
                MessageBox.Show(mensagem, "Info",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você deve escolher uma operação!",
                    "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
