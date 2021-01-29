using System;

namespace CursoCSharp.ClassesEMetodos {
    public enum Genero { Acao, Comedia, Romance, Terror, Suspense }
    class Filme {
        public string Nome;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum {
        public static void Executar() {
            var filme = new Filme();
            filme.Nome = "Filme Aleatório";
            filme.GeneroDoFilme = Genero.Suspense;
            Console.WriteLine(filme.Nome + ' ' + filme.GeneroDoFilme);

            var idGeneroComedia = (int)Genero.Terror;
            Console.WriteLine(idGeneroComedia);
        }
    }
}
