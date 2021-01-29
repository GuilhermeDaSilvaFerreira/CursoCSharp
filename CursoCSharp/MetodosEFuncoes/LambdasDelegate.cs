using System;

namespace CursoCSharp.MetodosEFuncoes {
    delegate double Operacao(double x, double y);
    class LambdasDelegate {
        public static void Executar() {
            Operacao somar = (a, b) => a + b;
            Operacao subtrair = (a, b) => a - b;
            Operacao multiplicar = (a, b) => a * b;

            Console.WriteLine(somar(1, 4));
            Console.WriteLine(subtrair(1, 4));
            Console.WriteLine(multiplicar(1, 4));
        }
    }
}
