using System;

namespace ProjetoCSharp.Fundamentos
{
    class OprAritmeticos
    {
        public static void Executar()
        {
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1; 

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;
            Console.WriteLine($"O preço final é: {totalComDesconto}");

            var peso = 84.5;
            var altura = 1.85;

            var imc = peso / Math.Pow(altura, 2);
            Console.WriteLine($"Imc = {imc}");

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto {1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);

        }
    }
}
