﻿using System;

class Programa
{
    static void Main(string[] args)
    {

        int fatorial = 1;

        for (int numero = 1; numero < 11 ; numero++)
        {
            fatorial *= numero;
            Console.WriteLine("Fatorial de " + numero + " = " + fatorial);

        }
    }
}