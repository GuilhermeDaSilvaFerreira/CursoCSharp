using System;

namespace Encapsulamento {
    public class SubCelebridade {
        // Todos que têm acesso a essa classe terão acesso à variável em qualquer projeto
        public string InfoPublica = "Tenho um Instagram";

        // Todos que herdarem essa classe terão acesso à variável em qualquer projeto
        protected string CorDosOlhos = "Verde";

        // Todos do mesmo projeto(assembly) que essa classe terão acesso à variável
        internal ulong NumeroDoCelular = 5131999999999;

        // Todos que herdarem essa classe OU do mesmo projeto que essa classe terão acesso à variável
        protected internal string JeitoDeFalar = "Uso muitas gírias";

        // Apenas essa classe OU todos que herdarem essa classe no mesmo projeto terão acesso à variável (versão c# >= 7.2)
        private protected string SegredoDeFamilia = "Uso muitas gírias";

        // Apenas essa classe tem acesso à variável
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Classe SubCelebridades:");

            Console.WriteLine("InfoPublica - " + InfoPublica);
            Console.WriteLine("CorDosOlhos - " + CorDosOlhos);
            Console.WriteLine("NumeroDoCelular - " + NumeroDoCelular);
            Console.WriteLine("JeitoDeFalar - " + JeitoDeFalar);
            Console.WriteLine("SegredoDeFamilia - " + SegredoDeFamilia);
            Console.WriteLine("UsaMuitoPhotoshop - " + UsaMuitoPhotoshop + "\n");
        }
    }
}
