using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class Produto {
        public string Nome;
        public double Preco;
    }
    class List {
        public static void Executar() {
            // O 'List' é indexado, homogêneo e permite repetição de itens iguais

            var produto1 = new Produto {
                Nome = "Blusa",
                Preco = 35.00,
            };

            List<Produto> carrinho = new List<Produto>();
            carrinho.Add(produto1);

            var combo = new List<Produto> {
                new Produto {
                    Nome = "Camiseta",
                    Preco = 29.99,
                },
                new Produto {
                    Nome = "Tênis",
                    Preco = 99.99,
                },
                new Produto {
                    Nome = "boné",
                    Preco = 99.99,
                },
            };

            carrinho.AddRange(combo);

            // É um tipo de coleção indexada
            carrinho.RemoveAt(3);

            Console.WriteLine(carrinho.Count);
            foreach (var item in carrinho) {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }

            // O List permite a adição de itens repetidos
            Console.WriteLine(carrinho.Count);
            carrinho.Add(produto1);
            Console.WriteLine(carrinho.Count);
            Console.WriteLine(carrinho.LastIndexOf(produto1));
        }
    }
}
