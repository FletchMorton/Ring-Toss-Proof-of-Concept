using System;

namespace Utilities {
    public static class ArrayUtilities
    {
        //Variables
        private static Random rng = new Random();

        //Fisher-Yates Shuffle algorithm
        public static void Shuffle<T>(this T[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = array[k];
                array[k] = array[n];
                array[n] = value;
            }
        }
    }
}
