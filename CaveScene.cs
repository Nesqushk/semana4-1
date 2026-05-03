using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
public class CaveScene : Situation
{
    public CaveScene()
    {
        Description = "Encuentras una cueva misteriosa.";

        Options.Add(new Option("Entrar a la cueva", p => p.Health -= 20));
        Options.Add(new Option("Rodear la cueva", p => p.Health -= 5));
    }
}