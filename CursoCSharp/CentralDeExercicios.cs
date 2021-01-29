using System;
using System.Collections.Generic;
using System.Linq;

namespace CursoCSharp {
    public class CentralDeExercicios {
        Dictionary<string, Action> Exercicios;

        public CentralDeExercicios(Dictionary<string, Action> exercicios) {
            Exercicios = exercicios;
        }

        public void SelecionarEExecutar() {
            int i = 1;

            Console.WriteLine("-1) Sair do programa\n");
            foreach (var exercicio in Exercicios) {
                Console.WriteLine("{0}) {1}", i, exercicio.Key);
                i++;
            }

            Console.Write("\nDigite o número do programa que deseja executar (ou vazio para o último): ");

            int.TryParse(Console.ReadLine(), out int num);
            if (num != -1) {
                bool numValido = num > 0 && num <= Exercicios.Count;

                num = numValido ? num - 1 : Exercicios.Count - 1;

                string nomeDoExercicio = Exercicios.ElementAt(num).Key;

                Console.Write("\nExecutando exercício ");
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine(nomeDoExercicio);
                Console.ResetColor();

                Console.WriteLine(String.Concat(Enumerable.Repeat("=", nomeDoExercicio.Length + 21)));

                Action executar = Exercicios.ElementAt(num).Value;
                try {
                    executar();
                    Console.WriteLine(String.Concat(Enumerable.Repeat("=", nomeDoExercicio.Length + 21)) + "\n");
                    SelecionarEExecutar();
                } catch (Exception e) {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Ocorreu um erro: {0}", e.Message);
                    Console.ResetColor();

                    Console.WriteLine(e.StackTrace);
                }
            } else {
                Console.Clear();
                Console.WriteLine("Fechando o programa.");
            }
        }
    }
}