using System;


namespace study56
{
    public class Player : Character
    {
        public Player()
        {
            SelectJob();
        }
        public Player(string name, int hp, int attack, int defense)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.defense = defense;
        }

        public void SelectJob()
        {
            Console.WriteLine("당신의 직업을 선택하세요");
            Console.WriteLine("1.기사 2.마법사 3.도적 ");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    name = "기사";
                    hp = 200;
                    attack = 10;
                    defense = 5;
                    break;
                case 2:
                    name = "마법사";
                    hp = 100;
                    attack = 20;
                    defense = 0;
                    break;
                case 3:
                    name = "도적";
                    hp = 150;
                    attack = 15;
                    defense = 2;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"직업업 : {name}");
            Console.WriteLine($"체력 : {hp}|| 공격력 : {attack}|| 방어력 : {defense}");
        }



    }
}