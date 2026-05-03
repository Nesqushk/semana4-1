using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

public class ForestScene : Situation
{
    public ForestScene()
    {
        Description = "Despiertas en un bosque oscuro.";

        Options.Add(new Option("Explorar el bosque", p => p.Health -= 10));
        Options.Add(new Option("Descansar", p => p.Health += 10));
    }
}