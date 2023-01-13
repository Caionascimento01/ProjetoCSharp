using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Fundamentos
{
    class FormatNum
    {
        public static void Executar() 
        {
            double num = 3.123456;
            // Uma casa decimal
            Console.WriteLine(num.ToString("F1"));
            // Valor monetário
            Console.WriteLine(num.ToString("C"));
            // Percentual
            Console.WriteLine(num.ToString("P"));
            // Formatação 0,00
            Console.WriteLine(num.ToString("#.##"));
            // Definindo cultura de uso
            CultureInfo cult = new CultureInfo("pt-BR");
            // Valor sem casas decimais
            Console.WriteLine(num.ToString("C0", cult));

            int x = 256;
            // Adicionando zeros à esquerda
            Console.WriteLine(x.ToString("D10"));

        }
    }
}
