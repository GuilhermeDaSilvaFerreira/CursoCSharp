using System;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegateFuncaoAnonima {
        delegate string OperacaoDeString(string s);
        public static void Executar() {
            OperacaoDeString inverter = delegate(string s) {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("Aprendendo C#"));

            OperacaoDeString inverter2 = (string s) => {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter2("Aprendendo C#"));
        }
    }
}
