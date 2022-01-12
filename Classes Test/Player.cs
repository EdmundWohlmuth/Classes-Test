using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    class Player
    {
        public int maxShield;
        public int maxHealth;

        public int health;
        public int shield;
        public int damage;

        public Player()
        {
            maxHealth = 100;
            maxShield = 50;

            health = 100;
            shield = 50;
            damage = 15;
        }

    }
}
