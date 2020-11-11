using System;
using System.Collections.Generic;

namespace ExercicioPropostoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            Console.Write("Quantos alunos estão matriculados no curso Algoritmo: ");
            int algoritmo = int.Parse(Console.ReadLine());
            for ( int i = 0; i < algoritmo; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> B = new HashSet<int>();
            Console.Write("Quantos alunos estão matriculados no curso Business Intelligense: ");
            int business = int.Parse(Console.ReadLine());
            for (int i = 0; i < business; i++)
            {
                B.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> C = new HashSet<int>();
            Console.Write("Quantos alunos estão matriculados no curso ASP . NET Core MVC: ");
            int core = int.Parse(Console.ReadLine());
            for (int i = 0; i < core; i++)
            {
                C.Add(int.Parse(Console.ReadLine()));
            }

            Console.WriteLine();
        
            HashSet<int> total = new HashSet<int>(A);
            total.UnionWith(B);
            total.UnionWith(C);
            Console.WriteLine("Total de alunos: " + total.Count);

            Console.ReadKey();
        }
    }
}
