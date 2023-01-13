using System;
using System.Globalization;

namespace ProjetoCSharp.Fundamentos
{
    class LendoDados
    {
        public static void Executar()
        {
            Console.WriteLine("Qual é o seu nome? ");
            string nome = Console.ReadLine();

            Console.WriteLine("Qual a sua idade? ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual é o seu salário? ");
            // O cultureInfo server para ignorar a cultura padrão do sistema permitindo usar como virgula(,) o ponto (.)
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"O {nome} tem {idade} anos e recebe R$ {salario}.");

        }
    }
}
