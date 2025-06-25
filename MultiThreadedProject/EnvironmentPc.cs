using System.Management;

namespace MultiThreadedProject
{
    public static class EnvironmentPc
    {
        public static void PrintEnvironmentInfo()
        {
            Console.WriteLine($"Версия операционной системы: {Environment.OSVersion}");
            Console.WriteLine($"Количество процессоров: {Environment.ProcessorCount}");
            Console.WriteLine($"Версия .NET: {Environment.Version}");
            try
            {
                using var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
                foreach (ManagementObject obj in searcher.Get())
                {
                    string model = obj["Name"]?.ToString() ?? "Unknown";
                    Console.WriteLine($"Модель процессора: {model}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}