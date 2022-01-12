using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            HUD HUD = new HUD();
            Player Player = new Player();

            HUD.DrawHUD();



            Console.ReadKey(true);
        }
    }
}
