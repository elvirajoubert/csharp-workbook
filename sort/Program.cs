using System;

namespace sort
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] x = new int[] { 14, 4, 17, 5, 8, 2, 1, 3, 9 };
            int temp = 0;
            for (int i = 0; i < x.Length; i++)
            {
                for (int j = i + 1; j < x.Length; j++)
                {
                    if (x[i] > x[j])
                    {
                        temp = x[j];
                        x[j] = x[i];
                        x[i] = temp;
                    }
                }
                Console.WriteLine(x[i]);
            }
            Console.ReadLine();
        }
    }
}



