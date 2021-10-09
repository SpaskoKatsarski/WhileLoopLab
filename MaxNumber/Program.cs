using System;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            double maxNum = double.MinValue;

            while (input != "Stop")
            {
                double currentNum = double.Parse(input);
                if (currentNum > maxNum)
                {
                    maxNum = currentNum;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(maxNum);
        }
    }
}
