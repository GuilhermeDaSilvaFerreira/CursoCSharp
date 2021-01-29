using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    class Construtores {
        public static void Executar() {
            Carro carro1 = new Carro();
            carro1.Modelo = "Sieana";
            carro1.Marca = "Fiat";
            carro1.AnoDeFabricacao = 2019;
            Console.WriteLine($"{carro1.Modelo} {carro1.Marca} {carro1.AnoDeFabricacao}");

            var carro2 = new Carro("Uno", "Fiat", 2010);
            Console.WriteLine($"{carro2.Modelo} {carro2.Marca} {carro2.AnoDeFabricacao}");

            var carro3 = new Carro() {
                Modelo = "Carro caro",
                Marca = "Ferrari",
                AnoDeFabricacao = 2021,
            };
            Console.WriteLine($"{carro3.Modelo} {carro3.Marca} {carro3.AnoDeFabricacao}");
        }
    }

    class Carro {
        public string Modelo;
        public string Marca;
        public int AnoDeFabricacao;

        public Carro() { }

        public Carro(string modelo, string marca, int ano) {
            Modelo = modelo;
            Marca = marca;
            AnoDeFabricacao = ano;
        }
    }
}
