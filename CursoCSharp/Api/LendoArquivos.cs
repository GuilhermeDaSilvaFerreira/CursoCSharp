using System;
using System.IO;

namespace CursoCSharp.Api {
    class LendoArquivos {
        public static void Executar() {
            var path = @"~/lendo_arquivos.txt".ParseHome();

            if (!File.Exists(path)) {
                using (StreamWriter sw = File.AppendText(path)) {
                    sw.WriteLine("Produto; Preço; Quantidade");
                    sw.WriteLine("Caneta; R$0,50; 3");
                    sw.WriteLine("Borracha; R$1,00; 2");
                }
            }

            try {
                using (StreamReader sr = new StreamReader(path)) {
                    string texto = sr.ReadToEnd();
                    Console.WriteLine(texto);
                }
            } catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
