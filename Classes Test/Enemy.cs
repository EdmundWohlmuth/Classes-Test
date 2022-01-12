using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    class Enemy
    {
        public int health;
        public int shield;
        public int damge;

        Player player = new Player();

        public void EnemyAttack(int damage)
        {
            Console.WriteLine("The enemy attacks!");       

            player.shield = player.shield - damage;

            Console.WriteLine("Player takes: " + damge + " damage!");
        }

        public Enemy()
        {
            health = 50;
            shield = 25;
            damge = 10;
        }
    }
}
