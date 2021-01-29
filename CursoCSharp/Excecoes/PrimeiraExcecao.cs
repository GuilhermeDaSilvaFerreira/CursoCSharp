using System;

namespace CursoCSharp.Excecoes {
    class Conta {
        public double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public double SacarDinheiro(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente para executar a ação!");
            }

            Saldo -= valor;
            return Saldo;
        }
    }
    class PrimeiraExcecao {
        public static void Executar() {
            var conta = new Conta(10_000);

            // Utilizando classe de erro mais genérica
            try {
                Console.WriteLine(conta.SacarDinheiro(20_000));
            } catch (Exception erro) {
                Console.WriteLine(erro.Message);
            } finally { // Executado depois do try ou do catch
                Console.WriteLine("Obrigado!");
            }

            // Utilizando classe de erro mais específica
            try {
                Console.WriteLine(conta.SacarDinheiro(20_000));
            } catch (ArgumentException erro) {
                Console.WriteLine(erro.Message);
            } finally {
                Console.WriteLine("Obrigado!");
            }

            // Sem dar erro
            try {
                Console.WriteLine(conta.SacarDinheiro(5_000));
            } catch (ArgumentException erro) {
                Console.WriteLine(erro.Message);
            } finally {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
