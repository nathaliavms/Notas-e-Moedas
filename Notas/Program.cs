using System;
using System.Globalization;

namespace Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal valorInformado = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("NOTAS:");
            Console.WriteLine((int)valorInformado / 100 + " nota(s) de R$ 100.00");
            valorInformado = valorInformado % 100;
            Console.WriteLine((int)valorInformado / 50 + " nota(s) de R$ 50.00") ;
            valorInformado = valorInformado % 50;
            Console.WriteLine((int)valorInformado / 20 + " nota(s) de R$ 20.00");
            valorInformado = valorInformado % 20;
            Console.WriteLine((int)valorInformado / 10 + " nota(s) de R$ 10.00");
            valorInformado = valorInformado % 10;
            Console.WriteLine((int)valorInformado / 5 + " nota(s) de R$ 5.00");
            valorInformado = valorInformado % 5;
            Console.WriteLine((int)valorInformado / 2 + " nota(s) de R$ 2.00");

            valorInformado = valorInformado % 2;
            valorInformado = valorInformado * 100;

            Console.WriteLine("MOEDAS:");
            Console.WriteLine((int)valorInformado / 100 + " moeda(s) de R$ 1.00");
            valorInformado = valorInformado % 100;
            Console.WriteLine((int)valorInformado / 50 + " moeda(s) de R$ 0.50");
            valorInformado = valorInformado % 50;
            Console.WriteLine((int)valorInformado / 25 + " moeda(s) de R$ 0.25");
            valorInformado = valorInformado % 25;
            Console.WriteLine((int)valorInformado / 10 + " moeda(s) de R$ 0.10");
            valorInformado = valorInformado % 10;
            Console.WriteLine((int)valorInformado / 5 + " moeda(s) de R$ 0.05");
            valorInformado = valorInformado % 5;
            Console.WriteLine((int)valorInformado + " moeda(s) de R$ 0.01");
        }
    } 
}
