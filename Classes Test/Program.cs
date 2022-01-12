using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    class Program
    {
        static bool playing;

        static void Main(string[] args)
        {
            playing = true;

            HUD HUD = new HUD();
            Player Player = new Player();

            HUD.DrawHUD();



            Console.ReadKey(true);
        }
    }
}
