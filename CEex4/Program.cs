﻿namespace CEex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro número: ");
            int num1 = int.Parse(Console.ReadLine()!);

            Console.Write("Digite o segundo número");
            int num2 = Convert.ToInt32(Console.ReadLine()!);

            Console.Write("Digite o terceiro número");
            int num3 = Convert.ToInt32(Console.ReadLine()!);

            int maior = Math.Max(num1, num2);
            maior = Math.Max(maior, num3);   

            Console.WriteLine($"O número {maior} é o maior valor");
        }
    }
}
