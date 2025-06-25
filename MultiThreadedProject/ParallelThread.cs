using System.Diagnostics;
using System.Threading;

namespace MultiThreadedProject
{
    public static class ParallelThread
    {
        public static (long sum, long ms) Sum(int[] array, int threadCount = 4)
        {
            var sw = Stopwatch.StartNew();
            long total = 0;
            int length = array.Length;
            long[] partialSums = new long[threadCount];
            Thread[] threads = new Thread[threadCount];
            for (int t = 0; t < threadCount; t++)
            {
                int localT = t;
                threads[t] = new Thread(() =>
                {
                    int start = localT * length / threadCount;
                    int end = (localT + 1) * length / threadCount;
                    long sum = 0;
                    for (int i = start; i < end; i++)
                        sum += array[i];
                    partialSums[localT] = sum;
                });
                threads[t].Start();
            }
            foreach (var thread in threads)
                thread.Join();
            for (int t = 0; t < threadCount; t++)
                total += partialSums[t];
            sw.Stop();
            return (total, sw.ElapsedMilliseconds);
        }
    }
}
