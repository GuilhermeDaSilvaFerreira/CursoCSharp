using System;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegatePorParametro {
        public delegate int Operacao(int x, int y);
        
        public static int Somar(int a, int b) {
            return a + b;
        }
        public static int Calculadora(Operacao op, int a, int b) {
            return op(a, b);
        }
        public static void Executar() {
            Operacao subtrair = (int a, int b) => a - b;
            Console.WriteLine(Calculadora(subtrair, 5, 3));

            Console.WriteLine(Calculadora(Somar, 5, 3));
        }
    }
}
