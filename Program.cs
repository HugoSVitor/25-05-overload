using System;
using POOAula2505x2.Classes;

namespace POOAula2505x2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionarios f = new Funcionarios();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um item para a lista: ");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("\nMostrar sem argumentos");
            f.Mostrar();

            Console.WriteLine("\nMostrar com argumentos int");
            f.Mostrar(2);

            Console.WriteLine("\nMostrar com argumentos string");
            f.Mostrar("manga");

        }
    }
}
