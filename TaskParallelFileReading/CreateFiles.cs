using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskParallelFileReading
{
    internal static class CreateFiles
    {
        public static void CreateThreeFiles(string pathDirectory)
        {
            Directory.CreateDirectory(pathDirectory);

            string[] contents = new string[]
            {
                "Яркое солнце, светит высоко, греет тепло, небо ясно, лучи прямые, день прекрасный, погода отличная, свет ослепляет, тепло ощущается, природа радуется.\n",
                "Ветер свежий, листья шелестят, облака плывут, птицы поют, трава зеленеет, воздух чистый, настроение бодрое, день начинается, солнце встаёт, мир просыпается.\n",
                "Дождь моросит, капли стучат, зонт раскрыт, лужи блестят, небо серое, прохлада ощущается, улицы пусты, тишина вокруг, свежесть в воздухе, природа отдыхает.\n"
            };

            for (int i = 1; i <= 3; i++)
            {
                string filePath = Path.Combine(pathDirectory, $"TextFile{i}.txt");
                File.WriteAllText(filePath, contents[i - 1], Encoding.UTF8);
            }
        }
    }
}
