using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelFileReading
{
    internal static class ReadFiles
    {
        public static async Task<int> CountSpacesInAllFilesAsync(string directoryPath)
        {
            // Получаем все текстовые файлы в папке
            var files = Directory.GetFiles(directoryPath, "TextFile*.txt");
            var tasks = new List<Task<int>>();

            foreach (var file in files)
            {
                tasks.Add(Task.Run(() => CountSpacesInFile(file)));
            }

            int[] results = await Task.WhenAll(tasks);
            return results.Sum();
        }

        private static int CountSpacesInFile(string filePath)
        {
            string content = File.ReadAllText(filePath, Encoding.UTF8);
            return content.Count(c => c == ' ');
        }
    }
}
