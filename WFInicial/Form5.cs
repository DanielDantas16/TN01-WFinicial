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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnmaiorMenor_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(textBox1.Text);
            int num2 = int.Parse(textBox2.Text);
            int num3 = int.Parse(textBox3.Text);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(num3, maior);

            int menor = Math.Min(num1, num2);
            menor = Math.Min(num3, menor);

            string mensagem = $"O número {maior} é o maior número!";
            mensagem += $"O número {menor} é o menor número!";

            MessageBox.Show(mensagem, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
