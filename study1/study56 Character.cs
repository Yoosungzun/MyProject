using System;


namespace study56
{
    public class Character
    {
        public string name;
        public int hp;
        public int attack;
        public int defense;

        public void TakeDamage(int damage)
        {
            hp -= damage - defense;
        }
    }



}