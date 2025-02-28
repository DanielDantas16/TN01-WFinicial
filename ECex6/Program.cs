namespace ECex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe o seu Nome: ");
            string nome = Console.ReadLine()!;

            Console.WriteLine("Informe o numero de horas trabalhadas: ");
            int quantidadedeHoras = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o valor da hora: ");
            double valorHora = Convert.ToDouble(Console.ReadLine());    

            double resultado = valorHora * quantidadedeHoras;

            Console.WriteLine($"A renda total de {nome} é de R$ {resultado:F2}");
        }
    }
}
