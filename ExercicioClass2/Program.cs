// Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário médio dos funcionários.
using ExercicioClass2;
using System;
using System.Globalization;

namespace ExercicioCriacaoDeClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios x, y;
            x = new Funcionarios();
            y = new Funcionarios();

            Console.Write("Digite o nome do Primeiro Funcionario: ");
            x.Nome = Console.ReadLine();
            Console.Write("Digite o seu salario R$");
            x.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");
            Console.Write("Digite o nome do segundo funcionario: ");
            y.Nome = Console.ReadLine();
            Console.Write("Digite o seu salario R$");
            y.Salario = double.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            double media = (x.Salario + y.Salario) / 2;
            Console.WriteLine("A média salarial dos funcionarios é de R${0}", media);
        }
    }
}
