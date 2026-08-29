using System;

namespace App
{
    public class HybridCache
    {
        private int _state;

        public HybridCache(int seed) => _state = seed;

        public int fetch(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 50) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new HybridCache(50);
            Console.WriteLine(obj.fetch(50));
        }
    }
}
