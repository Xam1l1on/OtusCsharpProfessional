using System.Diagnostics;

namespace MultiThreadedProject
{
    public static class NotParallel
    {
        public static (long sum, long ms) Sum(int[] array)
        {
            var sw = Stopwatch.StartNew();
            long sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sw.Stop();
            return (sum, sw.ElapsedMilliseconds);
        }
    }
}
