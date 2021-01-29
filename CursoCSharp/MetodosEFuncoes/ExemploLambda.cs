using System;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            // Action representam funções void
            Action<string> imprimirNoConsole = (texto) => { // Lambda == Função anônima
                Console.WriteLine(texto);
            };
            imprimirNoConsole("Lambda com C#");

            // Func representam funções com retorno, ondo o último parâmetro do Generics é o tipo de retorno
            Func<int> jogarDado = () => {
                Random random = new Random();
                return random.Next(0, 9);
            };
            imprimirNoConsole(jogarDado().ToString());

            // Todos os parâmetros antes do tipo de retorno representam os tipos dos parâmetros das funções
            Func<int, string> converterParaHexadecimal = numeroDecimal => numeroDecimal.ToString("X");
            imprimirNoConsole(converterParaHexadecimal(22));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2}", dia, mes, ano);
            imprimirNoConsole(formatarData(2, 3, 2021));
        }
    }
}
