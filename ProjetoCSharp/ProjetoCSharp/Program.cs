﻿using System;
using System.Collections.Generic;

using ProjetoCSharp.Fundamentos;

namespace CursoCSharp {
    class Program {
        static void Main(string[] args) {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                {"Primeiro Programa - Fundamentos", PriPrograma.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}