using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2901_b
{
    class Program
    {

        Random r = new Random(); // global

        static void Main(string[] args)
        {
            /*
            for (int i = 0; i < 100; i++)
            {
              
                if (isZugi(i)) //(isZugi(i) == true)
                {
                    Console.WriteLine(i);
                }
                if (!isZugi(i))
                {

                }
            }

            bool flag = true;
            flag = !flag;
            */

            int[] arr = { 1, 5, 7, 9 };
            do1(arr);
            arr[0] = Convert.ToInt32(Console.ReadLine());

            int[] arr8;
            CreateArray(out arr8);

            int[] arr2 = new int[3];
            arr2[0] = 1;
            arr2[1] = 5;
            arr2[2] = 15;

            int[,] matrix = new int[5, 3]
            {
                {1, 2, 3 },
                {5, 6, 7 },
                {1, 2, 3 },
                {5, 6, 7 },
                {1, 2, 3 }
            };
            matrix[0, 0] = 1;
            matrix[0, 1] = 3;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write( matrix[i, j] + " ");
                }
                Console.WriteLine();
            }

            int[][] jagged = new int[4][];
            jagged[0] = new int[10];
            jagged[1] = new int[1];
  

            int size = Convert.ToInt32(Console.ReadLine());
            int[] grades = new int[size];

            for (int i = 0; i < size; i++)
            {
                grades[i] = Convert.ToInt32(Console.ReadLine());
            }

            string[] words = { "i", "love", "dot net" };
            string text = "hello";
            char c1 = 'h';
            char[] chars = { 'h', 'e', 'l', 'l', 'o' };


        }
        public static void CreateArray(out int[] arr3)
        {
            arr3 = new int[2] { 5, 6 };
        }

        public static void do1(int[] arr2)
        {
            arr2[0] = 10;
        }

        public static int MaxInArray(int[] theArray)
        {
            if (theArray.Length == 0)
            {
                return int.MinValue;
            }

            int max = theArray[0];
            for (int i = 1; i < theArray.Length; i++)
            {
                if (theArray[i] > max)
                {
                    max = theArray[i];
                }
            }

            return max;
        }

        public static bool isZugi(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }

            return false;
        }
    }
}
