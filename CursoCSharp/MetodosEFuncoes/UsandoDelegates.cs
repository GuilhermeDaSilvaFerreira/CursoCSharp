using System;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegates {
        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double x, double y) {
            return x + y;
        }
        static void ImprimirMinhaSoma(double a, double b) {
            Console.WriteLine(a + b);
        }
        public static void Executar() {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(3, 5));

            ImprimirSoma op2 = ImprimirMinhaSoma;
            op2(3, 4);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(5, 5));

            Action<double, double> op4 = ImprimirMinhaSoma;
            op4(10, 1);
        }
    }
}
