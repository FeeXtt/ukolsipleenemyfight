
using ukolmore.Entities;

public class GameLoop
{
    private Player player;
    private List<Room> rooms;
    private Random random = new Random();

    public GameLoop(Player player)
    {
        this.player = player;
        InitializeRooms();
    }

    private void InitializeRooms()
    {
        rooms = new List<Room>
        {
                new Room(EnemyFactory.CreateGoblin()),
                new Room(treasure: new Weapon(WeaponType.Sword)),
                new Room(treasure: new Weapon(WeaponType.Axe)),
                new Room(EnemyFactory.CreateBoss())
            };
    }

    public void Play()
    {
        foreach (var room in rooms)
        {
            room.GoIn(player);

            while (room.Enemy != null && room.Enemy.StillAlive() && player.StillAlive())
            {
                Console.WriteLine("Vyber moynost 'zautoc', 'potka'");
                string action = Console.ReadLine();

                if (action == "zautoc")
                {
                    player.Attack(room.Enemy);
                    if (room.Enemy.StillAlive())
                    {
                        room.Enemy.Attack(player);
                    }
                }
                else if (action == "potka" && player.Potions.Count > 0)
                {
                    player.UsePotion(player.Potions[0]);
                }

                if (!player.StillAlive())
                {
                    Console.WriteLine("Porazil te!");
                    return;
                }
            }
        }

        Console.WriteLine("Porayil jsi vsechny!");
    }
}
