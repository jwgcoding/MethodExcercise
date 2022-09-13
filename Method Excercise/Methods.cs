using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Excercise
{
    internal class Methods
    {
        public static void Excercise1()
        {
            Console.WriteLine("Tell me your name and I will tell you a story.");
            var userName = Console.ReadLine();

            Console.WriteLine("Tell me your age.");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give me a dog name.");
            var dogName = Console.ReadLine();

            Console.WriteLine("What is ideal retirement age?");
            int oldAge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine("Where do you want to live?");
            var location = Console.ReadLine();

            Console.WriteLine($"There was a person named {userName}, who was {age} years old.");
            Console.WriteLine($"{userName} lived with their dog, {dogName} whose fur was colored {favColor}.");
            Console.WriteLine($"{userName} always dreamed of living in {location} until one day, they took the leap.");
            Console.WriteLine($"It was everything {userName} had hoped for and stayed there and retired at the age of {oldAge}.");
        }


        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
        public static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }
        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int x, int y)
        {
            return x % y;
        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i < list.Length; i++)
            {
                sum += list[i];
            }
            return sum;
        }
#region Utility Methods
        public static void AddBreak()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("***********************************************************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        public static void AddSmallBreak()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************************************************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        #endregion
    }
}
