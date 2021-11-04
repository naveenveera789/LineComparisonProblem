using System;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome Line Comparison Computation Program");
            LineCalculation lineOne = new LineCalculation(2.0, 9.0, 5.0, 16.0);
            double lengthOne = lineOne.LengthCalculate();
            Console.WriteLine("The length of the first line is {0}", lengthOne);
            LineCalculation lineTwo = new LineCalculation(7.0, 14.0, 3.0, 6.0);
            double lengthTwo = lineTwo.LengthCalculate();
            Console.WriteLine("The length of the second line is {0}", lengthTwo);
        }
    }
}
