namespace PracticeProblem03;

class Practice03
{
    /*
    * Fibonacci Sequence
    * Write a program that reads from the console number N and print the sum of the
    * first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377
    */
    static void hello()
    {
        Console.WriteLine("Hello, World!");
    }

    static int compute(int n)
    {
        if (n == 0) return 0;
        if (n == 1) return 1;

        int prev = 0;
        int next = 1;
        int sum = 0;

        for(int i = 2; i <= n; i++)
        {
            sum = prev + next;
            prev = next;
            next = sum;

            Console.WriteLine(sum);
        }
        return sum;
    }
    static void Main(string[] args)
    {
        hello();
        Console.Write("Enter Nunmber: ");
        string num = Console.ReadLine();
        int n = Convert.ToInt32(num);
        compute(n);
    }
}