namespace PracticeProblem03;

class Practice10
{
    static void Main(string[] args)
    {
        int[] numbers = { 0, 1, 0, 3, 12 };
        int n = numbers.Length;
        int index = 0;

        Console.Write("Original Array: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] != 0)
            {
                numbers[index++] = numbers[i];
            }
        }
        while (index < n)
        {
            numbers[index++] = 0;
        }

        Console.Write("Modified Array: ");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}
