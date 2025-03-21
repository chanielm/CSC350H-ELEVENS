﻿class Program
{
    public static void Main(String[] args)
    {
        // this part of the program only exists for debugging.
        ElevensGame e = new();

        while (e.ValidMovePossible())
        {
            e.SelectCards();
            if (e.ValidateEleven(e.Selection)) {
                Console.WriteLine("These Cards Add to 11. Removing...");
                e.ReplaceSelected();
            }
            else if (e.ValidateFaceCards(e.Selection)) {
                Console.WriteLine("These are unique face cards. Removing...");
                e.ReplaceSelected();
            }
            else Console.WriteLine("Invalid Selection.");
        }
        Console.WriteLine("GAME OVER");
        e.SelectCards();
    }
}