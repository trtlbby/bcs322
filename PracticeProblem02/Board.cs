namespace PracticeProblem02;

class Board
{
    private Card[,] grid;
    private static Random rng = new Random();

    public Board()
    {
        grid = new Card[4, 4];
        initialize();
        shuffle();
    }

    /*
    * Fill a flat array with pairs 1–8, then map into the 4x4 grid.
    */
    private void initialize()
    {
        int[] labels = new int[16];
        for (int i = 0; i < 8; i++)
        {
            labels[i * 2]     = i + 1;
            labels[i * 2 + 1] = i + 1;
        }

        int index = 0;
        for (int row = 0; row < 4; row++)
            for (int col = 0; col < 4; col++)
                grid[row, col] = new Card(labels[index++]);
    }

    /*
    * Shuffle by repeatedly selecting two cards at random and swapping them.
    */
    public void shuffle()
    {
        for (int i = 0; i < 300; i++)
        {
            int r1 = rng.Next(4), c1 = rng.Next(4);
            int r2 = rng.Next(4), c2 = rng.Next(4);
            Card temp    = grid[r1, c1];
            grid[r1, c1] = grid[r2, c2];
            grid[r2, c2] = temp;
        }
    }

    /*
    * Display the 4x4 board. Face-up cards show their label; face-down cards show *.
    */
    public void display()
    {
        Console.WriteLine("       1    2    3    4");
        Console.WriteLine("     +----+----+----+----+");
        for (int row = 0; row < 4; row++)
        {
            Console.Write("  {0}  |", row + 1);
            for (int col = 0; col < 4; col++)
            {
                if (grid[row, col].is_face_up())
                    Console.Write("  {0} |", grid[row, col].get_label());
                else
                    Console.Write("  * |");
            }
            Console.WriteLine();
            Console.WriteLine("     +----+----+----+----+");
        }
    }

    /*
    * Returns the card at the given 1-based (col, row) coordinate.
    */
    public Card get_card(int col, int row)
    {
        return grid[row - 1, col - 1];
    }

    /*
    * Returns true if all 16 cards are face-up (win condition).
    */
    public bool all_face_up()
    {
        for (int row = 0; row < 4; row++)
            for (int col = 0; col < 4; col++)
                if (!grid[row, col].is_face_up())
                    return false;
        return true;
    }

    /*
    * Returns true if the coordinate is in bounds (1–4) and the card is face-down.
    */
    public bool is_valid_pick(int col, int row)
    {
        if (col < 1 || col > 4 || row < 1 || row > 4)
            return false;
        return !grid[row - 1, col - 1].is_face_up();
    }
}
