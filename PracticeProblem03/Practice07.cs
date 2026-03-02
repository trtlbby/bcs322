namespace PracticeProblem03;
class Practice07
{
    /*
    * Number freq. 
    */
    static void Main(string[] args)
    {
        int[] inputData = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
        int[] counts = new int[100];
        int maxCount = 0;
        int mostFrequent = inputData[0];

        foreach (int value in inputData)
        {
            if (value >= 0 && value < counts.Length)
            {
                counts[value]++;
                if (counts[value] > maxCount)
                {
                    maxCount = counts[value];
                    mostFrequent = value;
                }
            }
        }

        Console.WriteLine($"Most frequent element: {mostFrequent} ({maxCount} times)");
    }
}
