using System;

namespace TipoDateTime
{
    class Program
    {
        static void Main(string[] arg)
        {
            var hoje = DateTime.Today;
            var agora = DateTime.Now;
            var data1 = new DateTime(2020, 03, 28);
            var data2 = new DateTime(2022, 02, 26, 11, 35, 00);
            var data3 = DateTime.Parse("26/02/2022 11:44:02");
            Console.WriteLine(hoje);
            Console.WriteLine(agora);
            Console.WriteLine(data1);
            Console.WriteLine(data2);
            Console.WriteLine(data3.Day);
            Console.WriteLine(data3.Month);
            Console.WriteLine(data3.Year);
            Console.WriteLine(data3.Hour);
            Console.WriteLine(data3.Minute);
            Console.WriteLine(data3.Second);
            Console.WriteLine(data3.Millisecond);
            Console.WriteLine(data3.AddDays(5)); // Adiciona ou subtrai conforme definição: 3, -1.
            Console.WriteLine(data3.ToLongDateString()); //Formatação estendida da data. 
            Console.WriteLine(data3.ToLongTimeString()); // Formatação estendida da hora.
            Console.WriteLine(data3.ToShortDateString()); // Formatação curta da data.
            Console.WriteLine(data3.ToShortTimeString()); // Formatação curta da hora.
        }
    }
}