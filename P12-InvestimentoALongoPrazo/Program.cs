using System;
using System.IO.Pipes;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 12 - Investindo a Longo prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        // encadeamento de laços de repetição
        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento += 0.001;
        }

        //Console.WriteLine("No mes " + mes); não e possivel utilizar fora do bloco de código de repetição
        Console.WriteLine("Depois de 5 anos você terá R$ " + investimento);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}

