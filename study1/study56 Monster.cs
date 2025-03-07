using System;


namespace study56
{
    public class Monster : Character
    {
        public Monster()
        {
            name = "";
            hp = 0;
            attack = 0;
            defense = 0;
        }
        public Monster(string name, int hp, int attack, int defense)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
        }



        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"이름 : {name}");
            Console.WriteLine($"체력 : {hp}|| 공격력 : {attack}|| 방어력 : {defense}");
        }



    }
}