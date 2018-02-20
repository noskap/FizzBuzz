using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizz Buzz counter");
            Console.Write("How high to count?");
            Console.WriteLine(fB(int.Parse(Console.ReadLine())));

            Console.ReadLine();
        }
        public static string fB(int inp)
        {
            string d = "";
            try
            {
                int i = inp / 3;
                d += "Fizz";
                try
                {
                    i = inp / 5;
                    d += "Buzz";
                }catch(Exception e)
                {
                    return "";
                }
            }
            catch(Exception e)
            {
                return inp.ToString();
            }
            return d;
        }
    }
}
