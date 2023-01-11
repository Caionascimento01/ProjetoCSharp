using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Fundamentos
{
    class VarEConst
    {
        public static void Executar()
        {
            // Area da circunfarencia
            double raio = 4.5;
            const double PI = 3.14;

            double area = PI * raio * raio;

            Console.WriteLine("Área é " + area);

            // Tipos internos

            bool EstaChovendo = true;
            Console.WriteLine("Esta chovando? (bool) " + EstaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade (byte) " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("SByte " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menValor = int.MinValue;
            Console.WriteLine("Menor valor int " + menValor);

            uint popBrasil = 207_000_000;
            Console.WriteLine("População Brasil " + popBrasil);

            long menValorLong = long.MinValue;
            Console.WriteLine("Menor valor Long " + menValorLong);

            ulong popMundial = 7_600_000_000;
            Console.WriteLine("Pop Mundial "+ popMundial);

            float precoComp = 1299.99f;
            Console.WriteLine("Preço PC " + precoComp);

            decimal distEstrelas = decimal.MaxValue;
            Console.WriteLine("Dist Estrelas decimal " + distEstrelas);

            char letra = 'a';
            Console.WriteLine("Letra " + letra);

            string palavra = "Toys";
            Console.WriteLine("Palavra " + palavra);
        }
    }
}
