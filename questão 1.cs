using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("qual sera o nomedo seu personagem: ");
        nome = Console.Readline() ?? string.Empty;

        Console.Write("qual e a idade do seu personagem: ");
        int.TryParse(Console.Readline(), out idade)

        Console.Write("qual e o nivel inicial do seu personagem: ");
        byte.TryParse(Console.Readline(), out nivelinicial);

        Console.Write("qual e a classe do seu personagem: ")
        classe = Console.Readline() ?? string.Empty;
        
    }
}