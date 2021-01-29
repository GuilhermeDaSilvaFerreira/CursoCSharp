using System;

namespace CursoCSharp.ClassesEMetodos {
    class ParametrosNomeados {
        public static string FormatarDataParaString(int dia, int mes, int ano) {
            return $"{dia:D2}/{mes:D2}/{ano}";
        }

        public static void Executar() {
            var dataFormatada = FormatarDataParaString(mes: 2, dia: 28, ano: 2002);
            Console.WriteLine(dataFormatada);
        }
    }
}
