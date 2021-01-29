using System;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] nomes = new string[3];
            nomes[0] = "Guilherme";
            nomes[1] = "Sarah";
            nomes[2] = "Felipe";

            foreach (var nome in nomes) {
                Console.WriteLine(nome);
            }

            double[] notas = { 9.5, 6.2, 4, 7.8 };
            double somatorio = 0;

            foreach (var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}
