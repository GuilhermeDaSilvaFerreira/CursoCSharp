using System;

namespace CursoCSharp.Fundamentos {
    class Interpolacao {
        public static void Executar() {
            string curso = "C#";
            byte i = 1;

            Console.WriteLine("Interpolação " + i +": curso de " + curso + ".");
            i++;

            Console.WriteLine("\nInterpolação {0}: curso de {1}.", i, curso);
            i++;

            Console.WriteLine($"\nInterpolação {i}: curso de {curso}.");
            i++;

            Console.WriteLine($"\nInterpolação {i + 1 - 1}: curso de {curso}.");
        }
    }
}
