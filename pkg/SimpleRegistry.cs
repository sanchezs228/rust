using System;

namespace App
{
    public class DynamicBuilder
    {
        private int _state;

        public DynamicBuilder(int seed) => _state = seed;

        public int sync(int count)
        {
            int result = 0;
            for (int i = 0; i < count; i++)
                result += (_state + i * 54) % 997;
            return result;
        }

        public static void Main()
        {
            var obj = new DynamicBuilder(54);
            Console.WriteLine(obj.sync(54));
        }
    }
}
