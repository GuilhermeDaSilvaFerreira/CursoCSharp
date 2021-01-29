using System;
using System.IO;

namespace CursoCSharp.Api {
    class Diretorios {
        public static void Executar() {
            var novoDir = "~/novoDiretorio".ParseHome();
            var novoDirDestino = "~/novoDiretorioDestino".ParseHome();
            var diretorioCurso = "~".ParseHome();

            if (Directory.Exists(novoDir)) {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino)) {
                Directory.Delete(novoDirDestino, true);
            }

            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));

            Console.WriteLine("======Pastas======");
            var diretorios = Directory.GetDirectories(diretorioCurso);
            foreach (var diretorio in diretorios) {
                Console.WriteLine(diretorio);
            }

            Console.WriteLine("======Arquivos======");
            var arquivos = Directory.GetFiles(diretorioCurso);
            foreach (var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
