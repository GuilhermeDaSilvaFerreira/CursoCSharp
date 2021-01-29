using System;

namespace Encapsulamento {
    public class AmigoProximo {
        public readonly SubCelebridade Amigo = new SubCelebridade();

        public void MeusAcessos() {
            Console.WriteLine("Classe AmigoProximo:");

            Console.WriteLine("InfoPublica - " + Amigo.InfoPublica);
            // Console.WriteLine("CorDosOlhos - " + Amigo.CorDosOlhos);
            Console.WriteLine("NumeroDoCelular - " + Amigo.NumeroDoCelular);
            Console.WriteLine("JeitoDeFalar - " + Amigo.JeitoDeFalar);
            // Console.WriteLine("SegredoDeFamilia - " + Amigo.SegredoDeFamilia);
            // Console.WriteLine("UsaMuitoPhotoshop - " + Amigo.UsaMuitoPhotoshop);
            Console.Write("\n");
        }
    }
}
