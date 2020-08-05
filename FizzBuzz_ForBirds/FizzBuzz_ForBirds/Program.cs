using System;
using System.Collections.Generic;

namespace Hodina3
{
    class Program
    {
        public static List<FizzBuzz> fizzBuzzes = new List<FizzBuzz>();

        static void Main(string[] args)
        {
            Writer(Fill); // makes it so u can have any number of items fill your list (viz FizzBuzz.Invoker)

            Console.Read();
        }
        private static void Writer(FizzBuzz.Invoker inv)
        {
            inv();
            foreach (dynamic x in fizzBuzzes)
                Console.Write(x.FizzBuzzIt + " ");
        }
        public static void Fill() // u can make your method and use it instead
        {
            for (int i = 0; i < 100; i++)
                fizzBuzzes.Add(new FizzBuzz(i)); // as long as it follows this (not realy)
        }
    }

    public class FizzBuzz
    {
        public delegate void Invoker();

        private enum Cases
        {
            Not = 0,
            Fizz = 1,
            Buzz = 2,
            FizzBuzz = 3,

        }

        private int incomigCheckerX { get; set; }

        public FizzBuzz(int x)
        {
            incomigCheckerX = x;
        }

        public string FizzBuzzIt { get { string FizzOrBuzzOrNotOrBoth = Check(incomigCheckerX); return FizzOrBuzzOrNotOrBoth; } }

        private string Check(int x)
        {
            string cheked = CheckModulo(x).ToString();
            return cheked;
        }

        private Cases CheckModulo(int x)
        {
            int TotalPoints = 0;

            if ((x % 3) == 0 & (x % 5) == 0)
                TotalPoints = 3;
            else if ((x % 5) == 0)
                TotalPoints = 2;
            else if ((x % 3) == 0)
                TotalPoints = 1;
            else
                return (Cases)Enum.Parse(typeof(Cases), x.ToString());

            return (Cases)Enum.Parse(typeof(Cases), TotalPoints.ToString());
        }
    }
}
