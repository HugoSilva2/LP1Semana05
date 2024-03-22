using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyGame
{
    public class Enemy
    {
        public string GetName()
        {
            return name;
        }

        public string SetName()
        {

        }
        public void TakeDamage(float damage)
        {
            shield -= damage;
            if (shield < 0)
            {
                float damageStillToInflict = -shield;
                shield = 0;
                health -= damageStillToInflict;
                if (health < 0) health = 0;
            }
        }

        public
        private string name;
        private float health;
        private float shield;

        //Construtor
        public Enemy(string name)
        {
            this.name = name; //name oculta this.name
            health = 100;
            shield = 0;
        }
    }
}