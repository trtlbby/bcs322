using System.Linq;
using System;

namespace BasicProblems;

class Program
{
    static int flip()
    {
        Random rnd = new Random();
        int coin = rnd.Next(0,2); //NOTES: instead of 0,1 -> use 0,2 
        return coin;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("The Coin Toss Simulator");
        int toss = 80;
        List<char> headCount = new List<char>();  
        List<char> tailCount = new List<char>();  
        for(int i = 0; i != toss; i++)
        {
           int tossedCoin = flip();
           if(tossedCoin == 0)
            {
                headCount.Add('*');
            }
            else if(tossedCoin == 1)
            {
                tailCount.Add('*');
            }
            else
            {
                Console.WriteLine("Error: " + i);
            }
            i++;
        }
        String headResults = new string(headCount.ToArray());
        Console.WriteLine("HEADS: " + headResults);
    }
}
