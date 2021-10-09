using System;

namespace Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double sumMarks = 0;
            int grade = 1;
            double failedAttempts = 0;

            while (grade <= 12) 
            {
                double yearMark = double.Parse(Console.ReadLine());

                if (yearMark < 4)
                {
                    failedAttempts++;
                    if (failedAttempts == 2)
                    {
                        Console.WriteLine($"{name} has been excluded at {grade} grade");
                        return;
                    }
                    continue;
                }

                sumMarks += yearMark;
                grade++;
            }
            double averageGrade = sumMarks / 12;
            Console.WriteLine($"{name} graduated. Average grade: {averageGrade:f2}");
        }
    }
}
