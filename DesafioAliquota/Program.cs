using System;

class Programa
{
    static void Main(string[] args)
    {
        double salario = 3300.0;

        // De 1900.0 até 2800.0 o IR é de 7.5% e pode deduzir R$ 142
        // De 2800.01 até 3751.0 o IR é de 15% e pode deduzir R$ 350
        // De 3751.01 até 4664.00 o IR é de 22.5% e pode deduzir R$ 636

        if (salario >= 1900.0 && salario <= 2800.0)
        {
            Console.WriteLine(@"o IR é de 7.5% 
pode deduzir na declaração o valor de R$ 142");
        }
        else if (salario >= 2800.1 && salario <= 3751.0)
        {
            Console.WriteLine(@"o IR é de 15%
pode deduzir R$ 350");
        }
        else
        {
            Console.WriteLine(@"o IR é de 22.5%
pode deduzir R$ 636");
        }
    }
}