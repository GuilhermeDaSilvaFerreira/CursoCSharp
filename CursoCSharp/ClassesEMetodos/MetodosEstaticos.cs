using System;

namespace CursoCSharp.ClassesEMetodos {
    class CalculadoraEstatica {
        // Método de classe ou método estático
        public static int Somar(int a, int b) {
            return a + b;
        }

        // Método de instância
        public int Subtrair(int a, int b) {
            return a - b;
        }
    }
    class MetodosEstaticos {
        public static void Executar() {
            var resultadoSoma = CalculadoraEstatica.Somar(1, 2);
            Console.WriteLine(resultadoSoma);
            
            var calculadoraEstatica = new CalculadoraEstatica();
            var resultadoSubtracao = calculadoraEstatica.Subtrair(1, 2);
            Console.WriteLine(resultadoSubtracao);
        }
    }
}
