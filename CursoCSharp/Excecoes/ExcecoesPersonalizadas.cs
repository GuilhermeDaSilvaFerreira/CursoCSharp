using System;

namespace CursoCSharp.Excecoes {
    public class NegativoException : Exception {
        public NegativoException() { }
        public NegativoException(string menssagem) : base(menssagem) { }
        public NegativoException(string menssagem, Exception inner) : base(menssagem, inner) { }
    }
    public class ImparException : Exception {
        public ImparException(string menssagem) : base(menssagem) { }
    }
    class ExcecoesPersonalizadas {
        public static int PositivoPar() {
            Random random = new Random();
            var valorAleatorio = random.Next(-30, 30);

            if (valorAleatorio < 0) {
                throw new NegativoException("Erro - Valor negativo.");
            } else if(valorAleatorio % 2 == 1) {
                throw new ImparException("Erro - Valor impar.");
            }

            return valorAleatorio;
        }
        public static void Executar() {
            try { 
                Console.WriteLine(PositivoPar());
            } catch (NegativoException ex) {
                Console.WriteLine(ex.Message);
            } catch (ImparException ex) {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
