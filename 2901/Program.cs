using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2901
{
    class Program
    {


        private static void GetNumbers(int a, int b, int c, double d1, float f1 = 8.8f)
        {
            double d = 5.5;
            float f = 5.5f;
            string name = "itay";
            Console.WriteLine("hello" + name + " !");
            Console.WriteLine($"hello {name} !");
        }

        private static int Power2(int x)
        {

            return x * x;
        }

        private static void MaxPower2(ref int z1, ref int z2)
        {
            z1 = z1 * z1;
            z2 = z2 * z2;
        }

        private static void MaxPower3(out int z1, out int z2)
        {
            z1 = Convert.ToInt32(Console.ReadLine());
            z1 = z1 * z1;

            z2 = Convert.ToInt32(Console.ReadLine());
            z2 = z2 * z2;
        }

        static void Main(string[] args)
        {

            int x1 = 5, x2 = 7;

            MaxPower2(ref x1, ref x2);

            int x3, x4;
            MaxPower3(out x3, out x4);

            Console.WriteLine($"x1 = {x1}");
            Console.WriteLine($"x2 = {x2}");

            //string st = Console.ReadLine();
            int number = Convert.ToInt32(Console.ReadLine());

            int result = Power2(number);
            Console.WriteLine($"{number}^2 = {result}");

            int y = 4;
            GetNumbers(5, 6, 7, 7.8);

            int x = 5;

            Console.WriteLine(Power2(2));
           
            //ClaculateAverage();

            //PrintResult();

            //Function1();

            ////
            ////
            ////

            //Function1();

            //Function1();
        }


    }
}
