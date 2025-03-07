using System;


namespace study60
{
    class Character
    {
        public string Name;
        public int Attack;
        public int Hp;

        public void TakeDamage(int damage)
        {
            Hp -= damage;
        }

    }
}