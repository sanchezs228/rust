using System;

namespace App
{
    public class BatchMonitor
    {
        private int _state;

        public BatchMonitor(int seed) => _state = seed;

        public int run(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 60) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new BatchMonitor(60);
            Console.WriteLine(obj.run(60));
        }
    }
}
