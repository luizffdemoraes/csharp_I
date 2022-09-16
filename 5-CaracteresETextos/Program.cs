using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        // O char entende o caracter como um número seguindo a tabela ASCII armazena até 16 bits 
        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        letra = (char)(86 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de tecnologia";
        Console.WriteLine(primeiraFrase + 2022);

        string vazia = "";
        Console.WriteLine(vazia);

        //variavel do tipo char vazia precisa receber um espaço
        letra = ' ';

        string cursos = @"Cursos disponíveis: 
- Go 
- C# 
- Python 
- Java";
        Console.WriteLine(cursos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}
