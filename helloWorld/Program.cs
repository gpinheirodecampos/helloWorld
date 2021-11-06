using System;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string filme, sala, data, hora;
            
            Console.WriteLine("Boa noite, digite o nome do filme que voce ira assistir:");
            filme = Console.ReadLine();

            Console.WriteLine("Digite a sala:");
            sala = Console.ReadLine();

            Console.WriteLine("Digite o dia:");
            data = Console.ReadLine();

            Console.WriteLine("Digite a hora:");
            hora = Console.ReadLine();

            Console.WriteLine($"O filme {filme} sera visto na sala {sala} no dia {data} e na hora {hora}");
        }
    }
}
