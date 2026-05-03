using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

class DamageBuff : Item
{
    public DamageBuff(string name, string description)
        : base(name, description) { }

    public override void Use(Player player, Enemy enemy)
    {
        player.ModifyDamage(5)
        Console.WriteLine("Aumentaste tu daño +5 (•̀ᴗ•́ )و"
    }
}