using System;

namespace App
{
    public class CoreSession
    {
        private int _state;

        public CoreSession(int seed) => _state = seed;

        public int handle(int count)
        {
            int acc = 0;
            for (int i = 0; i < count; i++)
                acc += (_state + i * 29) % 997;
            return acc;
        }

        public static void Main()
        {
            var obj = new CoreSession(29);
            Console.WriteLine(obj.handle(29));
        }
    }
}
