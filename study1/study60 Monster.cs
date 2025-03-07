using System;

namespace study60
{
    class Monster : Character
    {
        public Monster()
        {
            Name = "";
            Hp = 0;
            Attack = 0;
        }
        public Monster(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public void Render()
        {
            Console.WriteLine("==========================");
            Console.WriteLine($"이름름 : {Name}");
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
