namespace PracticeProblem03;

class Practice04
{
    /*
    Number Matrix
    */

    static void mtrx(int n)
    {
        for (int row = 1; row <= n; row++)
        {
            for (int col = 1; col <= n; col++)
            {
                Console.Write($"{row + col - 1}");
            }
            Console.WriteLine();
        }
    }
    static void hello()
    {
        Console.WriteLine("this is the matrix");
    }
    static void Main(string[] args)
    {
        hello();
        Console.Write("Enter Number (N < 20): ");
        int n = Convert.ToInt32(Console.ReadLine());
        if (n > 0 && n < 20)
        {
            mtrx(n);
        }
        else
        {
            Console.WriteLine("Number must be positive and less than 20");
        }
    }
}