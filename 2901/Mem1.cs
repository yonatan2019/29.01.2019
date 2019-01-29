using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2901
{
    class Mem1
    {

        public static int Power2(int x)
        {
            return x * x;
        }

        public static void Main2()
        {
            double d = 5.5;
            float f = 5.5f;
            string name = "itay";
            Console.WriteLine("hello" + name + " !");
            Console.WriteLine($"hello {name} !");

            int x = 1; //= Convert.ToInt32( Console.ReadLine()) ;

            //if (x % 2 == 0)
            //{
            //    Console.WriteLine($"{x} Zugi");
            //}
            //else
            //{
            //    Console.WriteLine($"{x} odd");
            //}


            if (x == 0)
            {
                Console.WriteLine("zero");

            }
            else if (x == 1)
            {
                Console.WriteLine("one");
            }
            else if (x == 2)
            {
                Console.WriteLine("two");
            }
            else
            {
                Console.WriteLine("not zero not one not two");
            }

            switch (x)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("two");
                    break;
                default:
                    Console.WriteLine("not zero not one not two");
                    break;
            }

            x = 0;
            Console.WriteLine("enter number until number > 0");
            x = Convert.ToInt32(Console.ReadLine());
            while (x <= 0)
            {
                Console.WriteLine("enter number until number > 0");
                x = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("x > 0");

            do
            {
                Console.WriteLine("enter number until number > 0");
                x = Convert.ToInt32(Console.ReadLine());
            }
            while (x <= 0);

            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            }
            while (j <= 10);

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            int sum = 0;
            for (int j2 = 0; j2 < 100; j2++)
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                if (grade < 0)
                {
                    continue;
                }
                sum = sum + grade;
                if (sum > 100_000)
                {
                    break;
                }
            }
            Console.WriteLine($"average is {(sum * 100.0)}");

            for (int i3 = 0; i3 < 10; i3++)
            {
                for (int i4 = 0; i4 < 10; i4++)
                {
                    break;
                }
                break;
            }
        }
    }
}
