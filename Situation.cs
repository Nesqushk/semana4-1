using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
public class Situation
{
    public string Description;
    public List<Option> Options = new List<Option>();

    public virtual void Play(Player player)
    {
        Console.WriteLine("\n" + Description);

        for (int i = 0; i < Options.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + Options[i].Text);
        }

        int choice = int.Parse(Console.ReadLine());
        Options[choice - 1].Effect(player);
    }
}