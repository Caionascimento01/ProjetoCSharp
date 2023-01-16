using System;

namespace ProjetoCSharp.Fundamentos
{
    class Conversões
    {
        public static void Executar() 
        {

            int inteiro = 10;
            double quebrado = inteiro;

            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTrunc = (int) nota;

            Console.WriteLine(notaTrunc);

            Console.Write("Digite sua idade: ");
            string IdadeString = Console.ReadLine();
            int IdadeInt = int.Parse(IdadeString);
            Console.WriteLine($"Idade é {IdadeInt}");

            IdadeInt = Convert.ToInt32(IdadeString);
            Console.WriteLine($"Idade convert = {IdadeString}");

            Console.WriteLine("Digite um número: ");
            string palavra  = Console.ReadLine();
            int num;
            int.TryParse(palavra, out num);
            Console.WriteLine("Resultado: {0}", num);

            Console.WriteLine("Digite um número: ");
            int.TryParse(Console.ReadLine(), out int num2);
            Console.WriteLine("Resultado2: {0}", num2);

        }
    }
}
