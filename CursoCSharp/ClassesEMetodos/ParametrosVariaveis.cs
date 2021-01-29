using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Calculadora {
        public static double Somar(params double[] fatores) {
            double soma = 0;

            foreach (var fator in fatores) {
                soma += fator;
            }

            return soma;
        }
    }
    class ParametrosVariaveis {
        public static void Executar() {
            var resultadoSoma = Calculadora.Somar(1, 1, 1, 1, 1, 1, 10);
            Console.WriteLine(resultadoSoma);
        }
    }
}
