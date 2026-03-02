namespace PracticeProblem03;

class Practice04
{
    /*
    Number Matrix
    */

    static void matrix(int n)
    {
        if (n < 20)
        {
            Console.WriteLine("Num less than 20");
        } else
        {
            Console.WriteLine("Num greater than 20");
        }
    }
    static void hello()
    {
        Console.WriteLine("dear diary, whr i lft u nd u lft me");
    }
    static void Main(string[] args)
    {
        hello();
        Console.Write("Enter Number: ");
        string num = Console.ReadLine();
        int n = Convert.ToInt32(num);
        matrix(n);
    }
}