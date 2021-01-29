using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            // First in first out
            var filaGenerica = new Queue<string>();
            filaGenerica.Enqueue("Guilherme");
            filaGenerica.Enqueue("Felipe");
            filaGenerica.Enqueue("Sarah");

            Console.WriteLine(filaGenerica.Count);
            Console.WriteLine(filaGenerica.Peek());
            Console.WriteLine(filaGenerica.Count);

            var fila = new Queue();
            fila.Enqueue("Guilherme");
            fila.Enqueue(true);
            fila.Enqueue(1);
            fila.Enqueue(5.478);

            Console.WriteLine(fila.Count);
            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);
        }
    }
}
