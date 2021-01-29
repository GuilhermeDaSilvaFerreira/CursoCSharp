using System;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesSet {
        public static void Executar() {
            // O 'Set' é não-indexado, homogêneo e não permite repetição de itens iguais

            var produto1 = new Produto {
                Nome = "Blusa",
                Preco = 35.00,
            };

            HashSet<Produto> carrinho = new HashSet<Produto>();
            carrinho.Add(produto1);

            var combo = new HashSet<Produto> {
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

            carrinho.UnionWith(combo);

            // É um tipo de coleção não indexada
            // carrinho.RemoveAt(3);

            Console.WriteLine(carrinho.Count);
            foreach (var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }

            // O Set não permite a adição de itens repetidos, mas também não retorna erro, o item simplesmente não é inserido
            Console.WriteLine(carrinho.Count);
            carrinho.Add(produto1);
            Console.WriteLine(carrinho.Count);
            // Console.WriteLine(carrinho.LastIndexOf(produto1));
        }
    }
}
