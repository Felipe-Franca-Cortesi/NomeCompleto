using System;

namespace NomeCompleto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();
            Console.Write("Digite seu sobrenome: ");
            string sobrenome = Console.ReadLine();

            string nomeCompleto = ($"{nome}{sobrenome}");
            Console.WriteLine($"Nome completo: {nomeCompleto} ");
            Console.WriteLine($"Nome catálogo: {sobrenome.ToUpper()}, {nome}");

        }
    }
}
