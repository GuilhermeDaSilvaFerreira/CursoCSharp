using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            // Estrutura composta por uma chave única para cada item e um valor que pode ser repetido
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homem-aranha");
            filmes.Add(2004, "Os incríveis");

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2004));
                Console.WriteLine("2022: " + filmes.GetValueOrDefault(2022));
                Console.WriteLine("2004: " + filmes.TryGetValue(2004, out string filme2004));
                Console.WriteLine("2022: " + filmes.TryGetValue(2022, out string filme2022));
                Console.WriteLine(filme2004);
                Console.WriteLine(filme2022);
            }

            Console.WriteLine(filmes.ContainsValue("Vingadores"));
            Console.WriteLine(filmes.ContainsValue("Homem-aranha"));

            Console.WriteLine("Removeu? " + filmes.Remove(2004));
            Console.WriteLine("Removeu? " + filmes.Remove(2022) + "\n");

            foreach (var chave in filmes.Keys) {
                Console.WriteLine(chave);
            }
            Console.Write("\n");
            foreach (var valor in filmes.Values) {
                Console.WriteLine(valor);
            }
            Console.Write("\n");
            foreach (KeyValuePair<int, string> filme in filmes) {
                Console.WriteLine($"{filme.Key}: {filme.Value}");
            }
            Console.Write("\n");
            foreach (var filme in filmes) {
                Console.WriteLine($"{filme.Key}: {filme.Value}");
            }
        }
    }
}
