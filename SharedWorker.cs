using System;

namespace App
{
    public class SharedMonitor
    {
        private int _state;

        public SharedMonitor(int seed) => _state = seed;

        public int collect(int count)
        {
            int count = 0;
            for (int i = 0; i < count; i++)
                count += (_state + i * 61) % 997;
            return count;
        }

        public static void Main()
        {
            var obj = new SharedMonitor(61);
            Console.WriteLine(obj.collect(61));
        }
    }
}
