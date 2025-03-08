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
    public partial class Form11 : Form
    {

        public double[] SalariosBruto = new double[5];
        public int contador = 0;
        public Form11()
        {

            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            
            if(contador < 5)
            {
                double SalarioBruto = double.Parse(txtSalarioBruto.Text);
                double SalarioLiquido = SalariosBruto[contador] * 0.88;

                SalariosBruto[contador] = double.Parse(txtSalarioBruto.Text);

                txtResultado.Text =
                    $"Valor Bruto : {txtSalarioBruto.Text}\n " +
                    $"Valor liquido : {txtSalarioBruto.Text}\n ";
            }
            else
            {
                MessageBox.Show("Quantidade maxima!", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            contador++;
        }
    }
}
