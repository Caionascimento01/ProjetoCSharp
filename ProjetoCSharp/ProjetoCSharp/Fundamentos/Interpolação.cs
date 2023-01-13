using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Fundamentos
{
    class Interpolação
    {
        public static void Executar()
        {
            string nome = "Notebook";
            string marca = "Acer";
            double valor = 3100.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + valor + ".");

            Console.WriteLine("O {0} da marca {1} custa {2}.", nome, marca, valor);

            Console.WriteLine($"A marca {marca} é legal");

            Console.WriteLine($"1 + 1 = {1+1}!");

        }
    }
}
