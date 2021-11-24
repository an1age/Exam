using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSPexam
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            PrintRandomNumber();
        }
        public static void PrintRandomNumber()
        {
            Random rand = new Random();
            Console.WriteLine(rand.Next(1000));
        }
    }
}
