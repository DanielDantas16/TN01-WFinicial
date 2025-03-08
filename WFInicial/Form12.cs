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
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        public int[] Numeros = new int[20];
        public int[] Par = new int[0];
        public int[] Impar = new int[0];
        public int contagem = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txtNumero.Text);
            Numeros[contagem] = numero;

            if(numero % 2 == 0)
            {
                Array.Resize(ref Par, Par.Length + 1);
                Par[contagem] = numero;

            }
            else
            {
                Array.Resize(ref Impar, Impar.Length + 1);
                Impar[contagem] = numero;
            }
            contagem++;

            if(contagem == 20){
                for(int i = 0; i <Numeros.Length; i++)
                {
                    lblNumeros.Text += numeros[i] + ",";
                }


            }
        }
    }
}
