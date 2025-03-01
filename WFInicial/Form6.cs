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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            double ValorDaHora = Convert.ToDouble(txtValorDaHora.Text);
            int QtdDeHoras = Convert.ToInt32(txtQtdDeHoras.Text);
            double resultado = ValorDaHora * QtdDeHoras;

            string mensagem = $"A renda total de {nome} é R$ {resultado:F2}";

            MessageBox.Show(mensagem, "Info",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }

       
    }

