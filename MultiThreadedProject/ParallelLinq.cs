using System.Diagnostics;
using System.Linq;

namespace MultiThreadedProject
{
    public static class ParallelLinq
    {
        public static (long sum, long ms) Sum(int[] array)
        {
            var sw = Stopwatch.StartNew();
            long result = array.AsParallel().Sum(x => (long)x);
            sw.Stop();
            return (result, sw.ElapsedMilliseconds);
        }
    }
}
