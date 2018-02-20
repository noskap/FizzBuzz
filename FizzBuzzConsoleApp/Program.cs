using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartFizzBuzz();
            

            Console.ReadLine();
        }

        private static void StartFizzBuzz()
        {
            Console.WriteLine("Fizz Buzz counter");
            Console.Write("How high to count?");
            int d = 0;
            if (int.TryParse(Console.ReadLine(), out d))
            {
                for (int i = 0; i < d; i++)
                {
                    Console.WriteLine(fB(d));
                }
            }
            else
            {
                Console.WriteLine("Input was not a number.");
            }

            Console.WriteLine("Continue? y/n");
            if (Console.ReadLine() == "Y" || Console.ReadLine() == "y")
            {// lowercase y doesnt work 
                StartFizzBuzz();
            }
        }

        public static string fB(int inp)
        {
            string d = "";
            try
            {
                int i = inp / 3;
                d += "Fizz ";
                try
                {
                    i = inp / 5;
                    d += "Buzz";
                }
                catch (Exception e)
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                return inp.ToString();
            }
            return d;
        }
    }
}
