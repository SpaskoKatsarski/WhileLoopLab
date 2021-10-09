using System;

namespace MinNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double minNum = double.MaxValue;

            while (input != "Stop")
            {
                double currentNum = double.Parse(input);
                if (currentNum < minNum)
                {
                    minNum = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(minNum);
        }
    }
}
