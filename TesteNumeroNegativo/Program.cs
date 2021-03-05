using System;

namespace TesteNumeroNegativo
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero_qualquer;

            Console.WriteLine("Digite um número qualquer: ");
            numero_qualquer = Convert.ToDouble(Console.ReadLine());
            // 0

            if(numero_qualquer > 0)
            {
                Console.WriteLine("Você digitou um número positivo.");

            } else if(numero_qualquer < 0)
            {
                Console.WriteLine("Você digitou um número negativo.");

            } else
            {
                Console.WriteLine("Você digitou zero.");
            } 



            Console.ReadKey();
        }
    }
}
