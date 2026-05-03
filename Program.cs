using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Player player = new Player();

        Situation forest = new ForestScene();
        Situation cave = new CaveScene();
        Situation temple = new TempleScene();

        forest.Play(player);
        Console.WriteLine("Vida actual: " + player.Health);

        cave.Play(player);
        Console.WriteLine("Vida actual: " + player.Health);

        temple.Play(player);
        Console.WriteLine("Vida actual: " + player.Health);

        Console.WriteLine("\nFin de la aventura.");
    }
}