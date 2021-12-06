using System;
namespace EBAUExercise.Services
{
    public static class CountingService
    {
        private static int _count = 0;

        public static void Increment()
        {
            _count += 1;
        }

        public static int Get()
        {
            return _count;
        }

        public static void Reset()
        {
            _count = 0;
        }
    }
}
