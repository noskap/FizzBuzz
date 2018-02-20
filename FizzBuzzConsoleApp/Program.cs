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
        }

        private static void StartFizzBuzz()
        {
            Console.WriteLine("Fizz Buzz counter");
            Console.Write("How high to count? ");
            int d = 0;
            if (int.TryParse(Console.ReadLine(), out d))
            {
                for (int i = 1; i < d+1; i++)
                {
                    Console.WriteLine(fB(i));
                }
            }
            else
            {
                Console.WriteLine("Input was not a number.");
            }

            Console.WriteLine("Continue? y/n");
            string y = Console.ReadLine();
            if (y == "Y" || y == "y")
            {// lowercase y doesnt work 
                StartFizzBuzz();
            }
        }

        public static string fB(int inp)
        {
            string d = "";
            d += Fizz(inp);
            d += Buzz(inp);
            if (d == "")
            {
                return inp.ToString();
            }
            else
            {
                return d;
            }
        }

        private static string Fizz(int inp)
        {
            decimal i = 0;
            try
            {
                i = inp / 3;
            }
            catch (Exception e)
            {
                return "";
            }
            if((inp % 3)>0)
            {
                return "";
            }else
            {
                return "Fizz ";
            }
            
        }

        private static string Buzz(int inp)
        {
            decimal i = 0;
            try
            {
                i = inp / 5;
            }
            catch (Exception e)

            {
                 return "";
            }
            if ((inp % 5) > 0)
            {
                return "";
            }
            else
            {
                return "Buzz";
            }
        }
    }
}
