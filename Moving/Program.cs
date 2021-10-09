using System;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int lenght = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());

            int volume = width * lenght * height;
            int allBoxesSize = 0;

            string input = Console.ReadLine();
            while (input != "Done")
            {
                int boxSize = int.Parse(input);
                allBoxesSize += boxSize;
                if (allBoxesSize > volume)
                {
                    int neededSpace = allBoxesSize - volume;
                    Console.WriteLine($"No more free space! You need {neededSpace} Cubic meters more.");
                    return;
                }
                input = Console.ReadLine();
            }
            int freeSpace = volume - allBoxesSize;
            Console.WriteLine($"{freeSpace} Cubic meters left.");
        }
    }
}
