namespace PracticeProblem03;

class Practice06
{
    static bool checkFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("sample doesn't exist");
            return false;
        }
        else
        {
            return true;
        }
    }

    static void readFile(string file)
    {
        string[] lines = File.ReadAllLines(file);
        int pairNum = 1;

        foreach (var line in lines)
        {
            var parts = line.Split('|');
            if (parts.Length != 2)
            {
                Console.WriteLine($"Line {pairNum}: invalid");
                pairNum++;
                continue;
            }
            
            int[] arr1 = parts[0].Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int[] arr2 = parts[1].Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            bool equal = arr1.Length == arr2.Length && arr1.SequenceEqual(arr2);

            Console.WriteLine($"Pair {pairNum}: {(equal ? "Equal" : "Not equal")}");
            pairNum++;
        }
    }

    static void Main(string[] args)
    {
        string filePath = "sampleArrays.txt";
        if(checkFile(filePath))
        {
            readFile(filePath);
        }
        else
        {
            Console.WriteLine($"This file: {filePath} doesn't exist");
        }
    }
}