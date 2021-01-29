using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            // First in last out
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push(true);
            pilha.Push("Guilherme");

            Console.WriteLine(pilha.Count);
            Console.WriteLine(pilha.Peek());
            Console.WriteLine(pilha.Count);

            var pilhaGenerica = new Stack<double>();
            pilhaGenerica.Push(4.2);
            pilhaGenerica.Push(3.1415);
            pilhaGenerica.Push(567.22);

            Console.WriteLine(pilhaGenerica.Count);
            Console.WriteLine(pilhaGenerica.Pop());
            Console.WriteLine(pilhaGenerica.Count);
        }
    }
}
