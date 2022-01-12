using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    public class HUD
    {
        Player player = new Player();

        public void DrawHUD()
        {
            Console.WriteLine("============");
            Console.WriteLine("Health: " + player.health + "/" + player.maxHealth);
            Console.WriteLine("Shield: " + player.shield + "/" + player.maxShield);
            Console.WriteLine("============");
            Console.WriteLine();
            Console.WriteLine("Press any key to continue");
        }
    }
}
