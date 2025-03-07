using System;
using System.Threading;

namespace study60
{
    class Field
    {
        Player player;
        Monster monster;
        public void SetPlayer(Player player)
        {
            this.player = player;
        }

        public void Initialize()
        {
            player = new Player();
        }

        public void Progress()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                DrawMap();
                input = int.Parse(Console.ReadLine());

                if (input == 4) break;
                else if (input <= 3)
                {
                    CreateMonster(input);
                    Fight();

                }

            }

        }
        public void Fight()
        {
            int input = 0;
            while (true)
            {
                Console.Clear();
                player.Render();
                monster.Render();
                Console.WriteLine("몬스터를 만났습니다.");
                Console.WriteLine("1.싸운다  2.도망간다");

                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    if (player.Hp > 0)
                    {
                        player.TakeDamage(monster.Attack);
                        monster.TakeDamage(player.Attack);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("체력이 없어 싸울 수 없습니다.");
                        Thread.Sleep(1000);
                        break;
                    }

                }
                if (input == 2 || (monster != null && monster.Hp <= 0))
                {
                    monster = null;
                    break;
                }
                else
                {
                    Console.WriteLine("잘못 누르셨습니다.");
                }
            }




        }
        public void Create(string name, int hp, int attack)
        {
            monster = new Monster(name, hp, attack);
        }
        public void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    Create("초급 몬스터", 30, 3);
                    break;
                case 2:
                    Create("중급 몬스터", 60, 6);
                    break;
                case 3:
                    Create("상급 몬스터", 90, 9);
                    break;
            }
        }

        public void DrawMap()
        {

            Console.WriteLine("맵을 선택하세요.");
            Console.WriteLine("=========================");
            Console.WriteLine("1. 초급 맵");
            Console.WriteLine("2. 중급 맵");
            Console.WriteLine("3. 고급 맵");
            Console.WriteLine("4. 돌아가기기");

        }

        //캐릭터(이름,공격력,hp,takeDamage)
        //플레이어(선택 함수,UI렌더)
        //몬스터(UI렌더)
        //필드(플레이어불러오기,맵선택하기,선택한맵에 몬스터 불러오기, 전투하기,)
        //게임메니저(플레이어 선택하기, 필드 선택 불러오기)
        //메인(게임메니저에 플레이어 선택하기, 필드선택하기 )

    }
}
