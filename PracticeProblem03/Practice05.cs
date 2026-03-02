namespace PracticeProblem03;

class Practice05
{
    static void arr()
    {
        int [] array = new int[20];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 5;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine($"Element[{i}] = {array[i]}");
        }
    }
    static void Main(string[] args)
    {
        arr();
    }
}