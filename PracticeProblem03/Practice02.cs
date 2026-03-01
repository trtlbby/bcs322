namespace PracticeProblem03;

/*
* A program that prints number from 1 (start) to N (end), that are NOT divisible by
* 3 and 7 SIMULTANOUESLY
*/

class Practice02
{
    static public int START = 1;
    static public int END;


    static public bool checkNum(int num)
    {
        if (num % 7 == 0)
        {
            return true;
        } else if (num % 3 == 0)
        {
            return true;
        } else
        {
            return false;        
        }
    }

    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string end = Console.ReadLine();
        END = Convert.ToInt32(end);

       while(START < END)
        {
            for(int i = START; i <= END; i++)
            {
                if (checkNum(i) == false)
                {
                    Console.WriteLine(START);
                }
                START++;
            }
        }     
    }
}
