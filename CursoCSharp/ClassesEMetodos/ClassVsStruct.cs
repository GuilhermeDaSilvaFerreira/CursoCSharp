using System;

namespace CursoCSharp.ClassesEMetodos {
    struct PontoStruct {
        public int X;
        public int Y;
    }
    class PontoClass {
        public int X;
        public int Y;
    }
    class ClassVsStruct {
        public static void Executar() {
            PontoStruct ponto1 = new PontoStruct { X = 1, Y = 3 };
            PontoStruct copiaPonto1 = ponto1; // Atribuição por VALOR
            ponto1.X = 3;

            Console.WriteLine(ponto1.X);
            Console.WriteLine(copiaPonto1.X);

            PontoClass ponto2 = new PontoClass { X = 1, Y = 3 };
            PontoClass copiaPonto2 = ponto2; // Atribuição por REFERÊNCIA
            ponto2.X = 3;

            Console.WriteLine(ponto2.X);
            Console.WriteLine(copiaPonto2.X);
        }
    }
}
