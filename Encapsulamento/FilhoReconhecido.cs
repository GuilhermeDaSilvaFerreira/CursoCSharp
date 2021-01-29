using System;

namespace Encapsulamento {
    public class FilhoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("Classe FilhoReconhecido:");

            Console.WriteLine("InfoPublica - " + InfoPublica);
            Console.WriteLine("CorDosOlhos - " + CorDosOlhos);
            Console.WriteLine("NumeroDoCelular - " + NumeroDoCelular);
            Console.WriteLine("JeitoDeFalar - " + JeitoDeFalar);
            Console.WriteLine("SegredoDeFamilia - " + SegredoDeFamilia);
            // Console.WriteLine("UsaMuitoPhotoshop - " + UsaMuitoPhotoshop);
            Console.Write("\n");
        }
    }
}
