using System;

namespace study60
{
    class Player : Character
    {
        public Player()
        {
            SelectJob();
        }
        public Player(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public void SelectJob()
        {
            Console.WriteLine("당신의 직업을 선택하세요.");
            Console.WriteLine("1.전사 2.마법사 3.도적");
            int input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Name = "전사";
                    Hp = 200;
                    Attack = 5;
                    break;

                case 2:
                    Name = "마법사";
                    Hp = 100;
                    Attack = 10;
                    break;

                case 3:
                    Name = "도적";
                    Hp = 150;
                    Attack = 7;
                    break;
            }
        }

        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"직업 : {Name}");
            Console.WriteLine($"체력 : {Hp}  공격력 : {Attack} ");
        }

        //캐릭터(이름,공격력,hp,takeDamage)
        //플레이어(선택 함수,UI렌더)
        //몬스터(UI렌더)
        //필드(플레이어불러오기,맵선택하기,선택한맵에 몬스터 불러오기, 전투하기,)
        //게임메니저(플레이어 선택하기, 필드 선택 불러오기)
        //메인(게임메니저에 플레이어 선택하기, 필드선택하기 )

    }
}
