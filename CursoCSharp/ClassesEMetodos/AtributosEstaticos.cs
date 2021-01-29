using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Produto {
        public double Valor;
        public static double Desconto = 1;

        public Produto() { }
        public Produto(double valor, double desconto) {
            Valor = valor;
            Desconto = desconto;
        }

        public double RetornarPreco() {
            return Valor * Desconto;
        }
    }
    class AtributosEstaticos {
        public static void Executar() {
            var produto1 = new Produto();
            produto1.Valor = 100;
            Console.WriteLine(produto1.RetornarPreco());

            var produto2 = new Produto();
            produto2.Valor = 50;
            Console.WriteLine(produto2.RetornarPreco());

            Produto.Desconto = 0.5;
            Console.WriteLine(produto1.RetornarPreco());
            Console.WriteLine(produto2.RetornarPreco());

            var produto3 = new Produto(100, 0.1);
            produto3.Valor = 100;
            Console.WriteLine(produto3.RetornarPreco());

            var produto4 = new Produto();
            produto4.Valor = 50;
            Console.WriteLine(produto4.RetornarPreco());
        }
    }
}
