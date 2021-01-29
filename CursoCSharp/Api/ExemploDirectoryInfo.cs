using System;
using System.IO;

namespace CursoCSharp.Api {
    class ExemploDirectoryInfo {
        public static void Executar() {
            var dirProjeto = "~".ParseHome();
            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }

            Console.WriteLine("=====Pastas=====");
            var diretorios = dirInfo.GetDirectories();
            foreach (var diretorio in diretorios) {
                Console.WriteLine(diretorio);
            }

            Console.WriteLine("\n=====Arquivos=====");
            var arquivos = dirInfo.GetFiles();
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.Parent.Parent);
        }
    }
}
