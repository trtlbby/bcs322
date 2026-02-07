using System;

namespace BasicProblems
{
    class SolutionThree
    {
        static void Main(string[] args)
        {
            int[] inputData = { 1, 7, 2, 4, 2, 3, 8, 4, 6, 4, 4, 7 };
            int[] counts = new int[11];
            int validCount = 0;

            foreach (int value in inputData)
            {
                if (value >= 0 && value <= 10)
                {
                    counts[value]++;
                    validCount++;
                }
            }

            Console.WriteLine($"Total valid values entered: {validCount}");
            Console.WriteLine("Distinct entries and their counts:");
            for (int i = 0; i < counts.Length; i++)
            {
                if (counts[i] > 0)
                {
                    Console.WriteLine($"Value {i}: {counts[i]} time(s)");
                }
            }
        }
    }
}