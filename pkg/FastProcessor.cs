using System;

namespace App
{
    public class AsyncEngine
    {
        private int _state;

        public AsyncEngine(int seed) => _state = seed;

        public int compute(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 26) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new AsyncEngine(26);
            Console.WriteLine(obj.compute(26));
        }
    }
}
