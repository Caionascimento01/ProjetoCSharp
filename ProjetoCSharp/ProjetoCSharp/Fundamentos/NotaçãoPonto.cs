using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Fundamentos
{
    class NotaçãoPonto
    {
        public static void Executar()
        {
            var saudacao = "olá".ToUpper().Insert(3, " world!").Replace("world!", "Mundo!");

            Console.WriteLine(saudacao);

            string valorImportante = null;

            // O caractere ? server para evitar erros, permitindo uma navegação segura.
            Console.WriteLine(valorImportante?.Length);

        }
    }
}
