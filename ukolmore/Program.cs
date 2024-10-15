using ukolmore.Entities;

class Program
{
    static void Main(string[] args)
    {
        Player player = new Player("Dingy", 100, 10);
        

        GameLoop game = new GameLoop(player);
        game.Play();
    }
}