using System;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // Valores inteiros
            byte valorByte = byte.MinValue;
            Console.WriteLine("Menor valor do 'byte': " + valorByte);
            valorByte = byte.MaxValue;
            Console.WriteLine("Maior valor do 'byte': " + valorByte);

            sbyte valorSbyte = sbyte.MinValue;
            Console.WriteLine("\nMenor valor do 'sbyte': " + valorSbyte);
            valorSbyte = sbyte.MaxValue;
            Console.WriteLine("Maior valor do 'sbyte': " + valorSbyte);

            short valorShort = short.MinValue;
            Console.WriteLine("\nMenor valor do 'short': " + valorShort);
            valorShort = short.MaxValue;
            Console.WriteLine("Maior valor do 'short': " + valorShort);

            int valorInt = int.MinValue;
            Console.WriteLine("\nMenor valor do 'int': " + valorInt);
            valorInt = int.MaxValue;
            Console.WriteLine("Maior valor do 'int': " + valorInt);

            uint valorUint = uint.MinValue;
            Console.WriteLine("\nMenor valor do 'uint': " + valorUint);
            valorUint = uint.MaxValue;
            Console.WriteLine("Maior valor do 'uint': " + valorUint);

            long valorLong = long.MinValue;
            Console.WriteLine("\nMenor valor do 'long': " + valorLong);
            valorLong = long.MaxValue;
            Console.WriteLine("Maior valor do 'long': " + valorLong);

            ulong valorUlong = ulong.MinValue;
            Console.WriteLine("\nMenor valor do 'ulong': " + valorUlong);
            valorUlong = ulong.MaxValue;
            Console.WriteLine("Maior valor do 'ulong': " + valorUlong);

            // Valores reais
            float valorFloat = float.MinValue;
            Console.WriteLine("\nMenor valor do 'float': " + valorFloat);
            valorFloat = float.MaxValue;
            Console.WriteLine("Maior valor do 'float': " + valorFloat);

            double valorDouble = double.MinValue;
            Console.WriteLine("\nMenor valor do 'double': " + valorDouble);
            valorDouble = double.MaxValue;
            Console.WriteLine("Maior valor do 'double': " + valorDouble);

            decimal valorDecimal = decimal.MinValue;
            Console.WriteLine("\nMenor valor do 'decimal': " + valorDecimal);
            valorDecimal = decimal.MaxValue;
            Console.WriteLine("Maior valor do 'decimal': " + valorDecimal);

            // Valores textuais
            char letra = 'a';
            Console.WriteLine("\nValor do 'char': " + letra);

            string frase = "frase";
            Console.WriteLine("\nValor da 'string': " + frase);

            // Valor booleano
            bool verdadeiro = true;
            Console.WriteLine("\nValor do 'bool': " + verdadeiro);

            bool falso = false;
            Console.WriteLine("Valor do 'bool': " + falso);

            // Declaração implícita
            var declaracaoImplicita = "Deve ser inicializada obrigatoriamente";
            Console.WriteLine("\nValor da variável declarada implicitamente: " + declaracaoImplicita);

            // Declaração de constante
            const string stringConstante = "Não pode ter seu valor alterado durante a execução";
            Console.WriteLine("\nValor da constante declarada como 'string': " + stringConstante);

        }
    }
}
