using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
public class TempleScene : Situation
{
    public TempleScene()
    {
        Description = "Llegas a un templo antiguo.";

        Options.Add(new Option("Tocar el altar", p => p.Health += 30));
        Options.Add(new Option("Ignorarlo", p => p.Health -= 10));
    }
}