using System;
using System.Collections;

namespace CursoCSharp.Colecoes {
    class ColecaoArrayList {
        public static void Executar() {
            // O 'ArrayList' é indexado, heterogêneo e permite repetição de itens iguais

            var arrayList = new ArrayList {
                "Teste",
                1,
                2,
                true,
                4.5,
                false,
                2,
            };

            foreach (var item in arrayList) {
                Console.WriteLine(arrayList.IndexOf(item));
                Console.WriteLine($"{item} - {item.GetType()}");
            }
        }
    }
}
