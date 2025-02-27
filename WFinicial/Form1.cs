namespace WFinicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularMedia_Click(object sender, EventArgs e)
        {
            double nota1 = double.Parse(txtNota1.Text);
            double nota2 = double.Parse(txtNota2.Text);

            double media = (nota1 + nota2) / 2;

            if (media > 7)
            {
                MessageBox.Show("Aprovado", "OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (media < 5)
            {
                MessageBox.Show("Reprovado", "Deu ruim", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Recuperação", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
