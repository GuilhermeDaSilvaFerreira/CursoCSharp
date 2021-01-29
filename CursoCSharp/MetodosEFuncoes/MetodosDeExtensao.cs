using System;

namespace CursoCSharp.MetodosEFuncoes {
    public static class ExtensoesInteiro {
        // Ao utilizar o this no primeiro parâmetro, você cria um método de extensão ao tipo daquele parâmetro
        public static int Somar(this int numeroAtual, int outroNumero) {
            return numeroAtual + outroNumero;
        }
        public static int Subtrair(this int numeroAtual, int outroNumero) {
            return numeroAtual - outroNumero;
        }
    }
    class MetodosDeExtensao {
        public static void Executar() {
            int numero = 5;
            Console.WriteLine(numero.Somar(5));
            Console.WriteLine(numero.Subtrair(5));

            Console.WriteLine(2.Somar(5));
            Console.WriteLine(40.Subtrair(5));
        }
    }
}
