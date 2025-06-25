using System;
using System.Diagnostics;
using MultiThreadedProject;

namespace MultiThreadedProject
{
    internal class Program
    {
        private static int[] _oneHundredThousand = new int[100_000];
        private static int[] _oneMillion = new int[1_000_000];
        private static int[] _tenMillion = new int[10_000_000];
        static void Main(string[] args)
        {
            FillArrays();
            Console.WriteLine("Массивы заполнены числами от 0 до 99\n");
            EnvironmentPc.PrintEnvironmentInfo();
            PrintTableHeader();
            PrintResult("Обычное", NotParallel.Sum(_oneHundredThousand), NotParallel.Sum(_oneMillion), NotParallel.Sum(_tenMillion));
            PrintResult("Thread", ParallelThread.Sum(_oneHundredThousand), ParallelThread.Sum(_oneMillion), ParallelThread.Sum(_tenMillion));
            PrintResult("Linq", ParallelLinq.Sum(_oneHundredThousand), ParallelLinq.Sum(_oneMillion), ParallelLinq.Sum(_tenMillion));
        }
        private static void FillArrays()
        {
            Random rand = new Random();
            for (int i = 0; i < _oneHundredThousand.Length; i++)
            {
                _oneHundredThousand[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < _oneMillion.Length; i++)
            {
                _oneMillion[i] = rand.Next(0, 100);
            }
            for (int i = 0; i < _tenMillion.Length; i++)
            {
                _tenMillion[i] = rand.Next(0, 100);
            }
        }
        private static void PrintTableHeader()
        {
            Console.WriteLine($"| Метод         | 100 000 (мс) | 1 000 000 (мс) | 10 000 000 (мс) |");
            Console.WriteLine(new string('-', 67));
        }
        private static void PrintResult(string method, (long sum, long ms) res1, (long sum, long ms) res2, (long sum, long ms) res3)
        {
            Console.WriteLine($"| {method,-13} | {res1.ms,12} | {res2.ms,14} | {res3.ms,15} |");
        }
    }
}
