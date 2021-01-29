using System;
using System.IO;

namespace CursoCSharp.Api {
    public static class ExtensaoString {
        public static string ParseHome(this string path) {
            var sistemaOperacional = Environment.OSVersion.Platform;
            string home;

            if (sistemaOperacional == PlatformID.Unix || sistemaOperacional == PlatformID.MacOSX) {
                home = Environment.GetEnvironmentVariable("HOME");
            } else {
                home = Environment.ExpandEnvironmentVariables("%HOMEDRIVE%%HOMEPATH%");
            }

            return path.Replace("~", home + "/Desktop/CursoCSharp");
        }
    }
    class PrimeiroArquivo {
        public static void Executar() {
            // O '@' faz com que a string não interprete textos como o '\n' como um comando, e sim um string realmente
            var path = @"~/primeiro_arquivo.txt".ParseHome();

            if (!File.Exists(path)) {
                // Using é usado para o programa liberar os recursos usados dentro do bloco 'using' depois da execução do mesmo
                // Ou seja, após criar os arquivos, os recursos usados para criação do mesmo são liberados
                using (StreamWriter sw = File.CreateText(path)) {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro arquivo");
                }
            }
            using (StreamWriter sw = File.AppendText(path)) {
                sw.WriteLine("");
                sw.WriteLine("É possível");
                sw.WriteLine("adicionar");
                sw.WriteLine("mais texto");
            }

        }
    }
}
