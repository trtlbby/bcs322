namespace BasicProblems;

class BinarySearch
{
    static void Main2(string[] args)
    {
        int[] numbers = { 23, 5, 17, 8, 42, 3, 15, 29, 1, 34, 19, 7, 12, 27, 10 };
        Array.Sort(numbers);

        Console.WriteLine($"Sorted Array: {string.Join(", ", numbers)}");

        int[] searchThis = {15 , 42, 2, 34, 100, 1, 8, 50};

        foreach(int num in searchThis)
        {
            int i = Array.BinarySearch(numbers, num);
            if(i >= 0)
            {
                Console.WriteLine($"Item {num} found at inventory slot {i}");
            }
            else
            {
                Console.WriteLine($"Item {num} not found in the inventory.");
            }
        }
    }
}
