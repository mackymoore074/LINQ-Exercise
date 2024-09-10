namespace LINQ
{
    public class Program
    { /*Use the list of Linq methods for help

        Create a list of video game names...
        Order the list of games by length of the game name.
        Use the lambda expression in this exercise as well.
        use Method Syntax for this exercise */
        static void Main(string[] args)
        {
            List<string> games = new List<string> { "Halo", "Call of Duty", "Fortnite", "Minecraft", "GTA", "Red Dead Redemption", "Assassins Creed", "FIFA", "NBA 2K", "Madden" };

            var orderedGames = games.OrderBy(g => g.Length);

            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }
            
        }
    }
}
