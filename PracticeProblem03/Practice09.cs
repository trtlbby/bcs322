namespace PracticeProblem03;
class Practice09
{
    static void Main(string[] args)
    {
        int[] nums = new int[5];
        Console.WriteLine("Enter 5 integer values:");
        for (int i = 0; i < 5; i++)
        {
            nums[i] = Convert.ToInt32(Console.ReadLine());
        }

        HashSet<int> positives = new HashSet<int>(nums.Where(x => x > 0));
        int missing = 1;
        while (positives.Contains(missing))
        {
            missing++;
        }

        Console.WriteLine($"First Missing Positive Integer: {missing}");
    }
}