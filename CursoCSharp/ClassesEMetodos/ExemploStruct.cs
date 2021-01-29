using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClassesEMetodos {
    struct Coordenada {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }
    }
    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.X = 1;
            coordenadaInicial.Y = 3;
            Console.WriteLine("{0}, {1}", coordenadaInicial.X, coordenadaInicial.Y);

            Coordenada coordenadaFinal = new Coordenada(5, 6);
            Console.WriteLine("{0}, {1}", coordenadaFinal.X, coordenadaFinal.Y);
        }
    }
}
