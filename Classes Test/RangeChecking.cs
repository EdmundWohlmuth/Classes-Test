using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    class RangeChecking
    {
        Player player = new Player();
        Enemy enemy = new Enemy();

        public void PlayerHealthRangeCheck()
        {
            player.shield = player.shield - enemy.damge;

            if (player.shield <= 0)
            {
                player.health = player.health + enemy.damge;
                player.shield = 0;

                if (player.health >= 0)
                {
                    player.health = 0;
                }
            }        
        }

        public void EnemyHealthRangeCheck()
        {
            if (enemy.shield <= 0)
            {
                enemy.health = enemy.health + enemy.damge;
                enemy.shield = 0;

                if (enemy.health >= 0)
                {
                    enemy.health = 0;
                }
            }
        }
    }
}
