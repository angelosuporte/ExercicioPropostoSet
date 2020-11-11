using System;
using System.Collections.Generic;

namespace ExercicioPropostoSet
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> A = new HashSet<int>();
            Console.Write("Informe quantos alunos estão matriculados no curso Algoritmo: ");
            int algoritmo = int.Parse(Console.ReadLine());
            for ( int i = 0; i < algoritmo; i++)
            {
                A.Add(int.Parse(Console.ReadLine()));
            }
            ImprimeCurso(A);
            Console.ReadKey();

        }

        static void ImprimeCurso<T>(IEnumerable<T> curso)
        {
            foreach (T aluno in curso)
            {
                Console.Write(aluno + " ");
            }
            Console.WriteLine();
        }
    }
}
