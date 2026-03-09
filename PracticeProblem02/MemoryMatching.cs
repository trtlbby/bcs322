namespace PracticeProblem02;

class MatchingMemory
{
    /*
    * Prompts the player for a coordinate and loops until a valid face-down card
    * within bounds (1–4) is entered. Returns a (col, row) tuple.
    */
    static (int col, int row) parse_input(string prompt, Board board, int? blocked_col = null, int? blocked_row = null)
    {
        while (true)
        {
            Console.Write(prompt);
            string? line = Console.ReadLine();
            string[] parts = (line ?? "").Trim().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (parts.Length != 2 ||
                !int.TryParse(parts[0], out int col) ||
                !int.TryParse(parts[1], out int row))
            {
                Console.WriteLine("  Invalid input. Enter two numbers separated by a space (e.g. 2 3).");
                continue;
            }

            if (col < 1 || col > 4 || row < 1 || row > 4)
            {
                Console.WriteLine("  Coordinates must be between 1 and 4.");
                continue;
            }

            if (blocked_col == col && blocked_row == row)
            {
                Console.WriteLine("  That card is already selected. Choose a different card.");
                continue;
            }

            if (!board.is_valid_pick(col, row))
            {
                Console.WriteLine("  That card is already face-up. Choose a face-down card.");
                continue;
            }

            return (col, row);
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("=== Memory Matching Game ===");
        Console.WriteLine("Enter coordinates as: col row  (e.g. '1 2' = column 1, row 2)\n");

        Board board = new Board();
        board.display();

        while (!board.all_face_up())
        {
            // --- First card ---
            var (c1, r1) = parse_input("\nFirst card  (col row): ", board);
            board.get_card(c1, r1).flip_up();
            board.display();

            // --- Second card (must differ from first) ---
            var (c2, r2) = parse_input("Second card (col row): ", board, c1, r1);
            board.get_card(c2, r2).flip_up();
            board.display();

            // --- Pause so the player can see both cards ---
            Thread.Sleep(2000);

            // --- Check for match ---
            if (board.get_card(c1, r1).get_label() == board.get_card(c2, r2).get_label())
            {
                Console.WriteLine("\n  Match! You got it right!.");
            }
            else
            {
                Console.WriteLine("\n  No match:(( Hiding cards...");
                board.get_card(c1, r1).flip_down();
                board.get_card(c2, r2).flip_down();

                // Force old board off the screen
                Console.Write(new string('\n', 40));
            }

            board.display();
        }

        Console.WriteLine("\nCongratulations! You matched all the cards!");
    }
}
