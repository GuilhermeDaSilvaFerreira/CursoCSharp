using System;

namespace CursoCSharp.Api {
    class ExemploTimeSpan {
        public static void Executar() {
            var intervalo = new TimeSpan(days: 10, hours: 20, minutes: 30, seconds: 40);
            Console.WriteLine(intervalo);

            Console.WriteLine("Minutos: " + intervalo.Minutes);
            Console.WriteLine("Intervalo em Minutos: " + intervalo.TotalMinutes);

            var largada = DateTime.Now;
            var chegada = DateTime.Now.AddMinutes(15);

            var tempoDemorado = chegada - largada; // O resultado dessa operação será um TimeSpan (intervalo de tempo)
            Console.WriteLine("Duração: " + tempoDemorado);
            Console.WriteLine(tempoDemorado.GetType().Name);

            Console.WriteLine(intervalo.Add(TimeSpan.FromMinutes(5))); // Gera um novo TimeSpan com um intervalo de 5 min adicionado
            Console.WriteLine(intervalo); 
            Console.WriteLine(intervalo.Subtract(TimeSpan.FromMinutes(5))); 
            Console.WriteLine(intervalo);

            Console.WriteLine("ToString 'g': " + intervalo.ToString("g"));
            Console.WriteLine("ToString 'G': " + intervalo.ToString("G"));
            Console.WriteLine("ToString 'c': " + intervalo.ToString("c"));

            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
        }
    }
}
