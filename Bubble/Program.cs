using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble
{
    internal class Program
    {

        public static void BubbleSort(int[] array)
        {
            int i, j, temp, n;

            n= array.Length;

            for(i = 0; i < n-1; i++)
            {
                for (j = n-1; j > 0; j--)
                {
                    if (array[j] < array[j - 1])
                    {
                        temp = array[j];
                        array[j] = array[j - 1];
                        array[j - 1] = temp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {

            int[] array = { 1, 2, 5, 4, 7, 2, 5, 12, 8, 124, 64 };

            BubbleSort(array);

            foreach(int i in array)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
