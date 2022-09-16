using System;

class Programa
{
    static void Main(string[] args)
    {
        for (int numero = 1; numero <= 100; numero++)
        {
            if (numero % 3 == 0)
            {
                Console.WriteLine("Multiplo de " + numero);
            }
        }

        Console.WriteLine("------------------------------");


        for (int numero = 3; numero <= 100; numero+=3)
        {
            Console.WriteLine("Multiplo de " + numero);
  
        }
    }
}