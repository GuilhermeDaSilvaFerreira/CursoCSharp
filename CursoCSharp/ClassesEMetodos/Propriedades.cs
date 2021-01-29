using System;

namespace CursoCSharp.ClassesEMetodos {
    class Pessoa {
        // Propriedade com set e get de forma que aparente ser um atributo público ao instanciar a classe
        // mas que na verdade utiliza d um atributo privado
        private string nome;
        public string Nome {
            get {
                return "Nome: " + nome;
            }
            set {
                nome = value;
            }
        }

        // Propriedade autoimplementada (já cria um atributo privado acessável por get e set)
        public int Idade { get; set; }

        // Somente leitura
        public string Descricao {
            get => Nome + ", idade: " + Idade; // Lambda (=>)
        }
    }
    class Propriedades {
        public static void Executar() {
            var pessoa = new Pessoa();
            pessoa.Nome = "Guilherme";
            pessoa.Idade = 19;

            Console.WriteLine(pessoa.Nome);
            Console.WriteLine(pessoa.Idade);
            Console.WriteLine(pessoa.Descricao);
        }
    }
}
