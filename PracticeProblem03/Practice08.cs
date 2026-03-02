namespace PracticeProblem03;
class Practice08
{
    /*
    * Triplets
    */
    static void Main(string[] args)
    {
        int[] numbers = { -1, 0, 1, 2, -1, -4 };
        Array.Sort(numbers);
        List<string> triplets = new List<string>();

        for (int i = 0; i < numbers.Length - 2; i++)
        {
            if (i > 0 && numbers[i] == numbers[i - 1]) continue;

            int left = i + 1;
            int right = numbers.Length - 1;

            while (left < right)
            {
                int sum = numbers[i] + numbers[left] + numbers[right];
                if (sum == 0)
                {
                    string triplet = $"[{numbers[i]}, {numbers[left]}, {numbers[right]}]";
                    if (!triplets.Contains(triplet))
                        triplets.Add(triplet);

                    left++;
                    right--;

                    while (left < right && numbers[left] == numbers[left - 1]) left++;
                    while (left < right && numbers[right] == numbers[right + 1]) right--;
                }
                else if (sum < 0)
                {
                    left++;
                }
                else
                {
                    right--;
                }
            }
        }

        Console.WriteLine("Triplets: " + string.Join(", ", triplets));
    }
}