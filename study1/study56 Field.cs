using System;
using System.Threading;

namespace study56
{
    class Field
    {
        Player player;
        Monster monster;
        public void SetPlayer(Player player)
        {
            this.player = player;
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

                if (input == 4)
                    break;
                if (input <= 3)
                {
                    //몬스터를 만나고
                    CreateMonster(input);

                    //몬스터와 싸우고
                    Fight();
                }
            }


        }

        public void Create(string name, int hp, int attack, int defense)
        {
            monster = new Monster(name, hp, attack, defense);
        }

        public void CreateMonster(int input)
        {

            switch (input)
            {
                case 1:
                    Create("초보몹", 30, 3, 0);
                    break;
                case 2:
                    Create("중수몹", 60, 6, 1);
                    break;
                case 3:
                    Create("고수몹", 90, 9, 2);
                    break;
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

                Console.WriteLine("1.공격 2.도망");
                input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    if (player.hp > 0)
                    {
                        player.TakeDamage(monster.attack);
                        monster.TakeDamage(player.attack);
                        if (player.hp <= 0)
                        {
                            Console.WriteLine("당신은 패배했습니다");
                            Thread.Sleep(1000);
                            break;
                        }


                    }
                    else
                    {
                        Console.WriteLine("체력이 없어 싸울수 없습니다.");
                        Thread.Sleep(1000);
                        break;
                    }


                }

                if (input == 2 || (monster != null && monster.hp <= 0))
                {
                    monster = null;
                    break;
                }
                else
                {
                    Console.WriteLine("잘못된 키를 누르셨습니다.");
                    break;
                }
            }

        }

        private void DrawMap()
        {
            Console.WriteLine("던전 난이도를 선택하세요.");
            Console.WriteLine("===============================");
            Console.WriteLine("1.초보맵");
            Console.WriteLine("2.중수맵");
            Console.WriteLine("3.고수맵");
            Console.WriteLine("4.전단계");
            Console.WriteLine("===============================");


        }
    }
}
