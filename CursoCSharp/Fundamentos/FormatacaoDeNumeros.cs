using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class FormatacaoDeNumeros {
        public static void Executar() {
            double valor = 15.175;
            Console.WriteLine("Valor original: " + valor);
            Console.WriteLine("\nvalor.ToString('F1'): " + valor.ToString("F1"));
            Console.WriteLine("\nvalor.ToString('C'): " + valor.ToString("C"));
            Console.WriteLine("\nvalor.ToString('P'): " + valor.ToString("P"));
            Console.WriteLine("\nvalor.ToString('#.##'): " + valor.ToString("#.##"));

            CultureInfo culturaAmericana = new CultureInfo("en-US");
            Console.WriteLine("\nvalor.ToString('C3', culturaAmericana): " + valor.ToString("C3", culturaAmericana));

            int valorInteiro = 256;
            Console.WriteLine("\nValor inteiro original: " + valorInteiro);
            Console.WriteLine("\nvalorInteiro.ToString('D10'): " + valorInteiro.ToString("D10"));
        }
    }
}
