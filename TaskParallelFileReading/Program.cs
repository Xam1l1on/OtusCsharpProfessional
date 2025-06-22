using System.Diagnostics;

namespace TaskParallelFileReading
{
    internal class Program
    {
        private static readonly string pathDirectory = @"Resources";
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            CreateFiles.CreateThreeFiles(pathDirectory);
            Stopwatch stopwatch = Stopwatch.StartNew();
            stopwatch.Start();
            int totalSpaces = await ReadFiles.CountSpacesInAllFilesAsync(pathDirectory);
            stopwatch.Stop();
            Console.WriteLine($"Время выполнения: {stopwatch.ElapsedMilliseconds} мс");
            Console.WriteLine($"Общее количество пробелов во всех файлах: {totalSpaces}");
        }
    }
}
