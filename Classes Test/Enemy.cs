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

        public void EnemyAttack(int damage)
        {
            Player player = new Player();

            player.shield = player.shield - damage;
        }

        public Enemy()
        {
            health = 50;
            shield = 25;
            damge = 10;
        }
    }
}
