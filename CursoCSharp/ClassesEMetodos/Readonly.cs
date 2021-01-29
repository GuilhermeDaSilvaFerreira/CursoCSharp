using System;
namespace CursoCSharp.ClassesEMetodos {
    class Cliente {
        public string Nome;
        // Não pode ser uma constante pois constantes não podem ser inicializadas pelo construtor, e sim já na declaração
        public readonly DateTime DataNascimento;

        public Cliente() { }
        public Cliente (string nome, DateTime dataNascimento) {
            Nome = nome;
            DataNascimento = dataNascimento;
        }
    }
    class Readonly {
        public static void Executar() {
            var cliente = new Cliente("Guilherme", new DateTime(2002, 1, 2));
            cliente.Nome = "Guilherme da Silva";
            // Não é possível por ser um campo de leitura
            // cliente.DataNascimento = new DateTime(2001, 1, 2);

            Console.WriteLine(cliente.Nome + " " + cliente.DataNascimento);
        }
    }
}
