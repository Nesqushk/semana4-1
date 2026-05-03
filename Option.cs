using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

public class Option
{
    public string Text;
    public System.Action<Player> Effect;

    public Option(string text, System.Action<Player> effect)
    {
        Text = text;
        Effect = effect;
    }
}