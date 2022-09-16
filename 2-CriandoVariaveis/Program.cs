using System;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

class Programa
{
   static void Main(string[] args)
    {
        int idade;
        idade = 27;

        Console.WriteLine("Minha idade é " + idade);

        idade = 27 - 5;

        Console.WriteLine(idade);

        idade = 5 * 2 - 6;

        Console.WriteLine(idade);

        idade = (5 - 2) * 3;

        Console.WriteLine(idade);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
