﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Test
{
    class Player
    {
        public int maxHealth;
        public int maxShield;

        public int health;
        public int shield;
        public int damage;

        Enemy enemy = new Enemy();

       public Player()
        {
            health = 100;
            shield = 50;
            damage = 12;
        }

        public void PlayerAttack()
        {
            Console.WriteLine("The player attacks!");

            enemy.shield = enemy.shield - damage;

            Console.WriteLine("Enemy takes: " + damage + " damage!");
        }
    }
}
