using System;
using System.Diagnostics.Eventing.Reader;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            YourAge();

            Console.ReadLine();
        }

        private static void YourAge()
        {
            int age;
            Console.WriteLine("Please enter your age ");
            age = Convert.ToInt32(Console.ReadLine());

            if (age == 18)
            {
                Console.WriteLine(" if you wanna get a driver's licanse , you can");
            }
            else if (age < 18)
            {
                Console.WriteLine("you're too young to get a driver's license");
            }
            else if (age > 18)
            {
                Console.WriteLine(" if you wanna get a driver's licanse , you can");
            }
            else
            {
                Console.WriteLine("Please enter your age correctly ");
            }
        }
    }
}