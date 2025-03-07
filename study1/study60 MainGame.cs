using System;

namespace study60
{
    class MainGame
    {
        Player player;
        Field field;

        public void Initialize()
        {
            player = new Player();
            field = new Field();
            field.SetPlayer(player);
        }

        public void Progress()
        {
            while (true)
            {

                Console.Clear();
                player.Render();
                Console.WriteLine("=======================");
                Console.WriteLine("행동을 선택하세요.");
                Console.WriteLine("1.던전 가기 2.종료");
                int input = int.Parse(Console.ReadLine());
                if (input == 2) break;
                if (input == 1)
                {
                    if (field == null)
                    {
                        field = new Field();
                    }
                    field.Progress();
                }
            }


        }
    }



    //캐릭터(이름,공격력,hp,takeDamage)
    //플레이어(선택 함수,UI렌더)
    //몬스터(UI렌더)
    //필드(플레이어불러오기,맵선택하기,선택한맵에 몬스터 불러오기, 전투하기,)
    //게임메니저(플레이어 선택하기, 필드 선택 불러오기)
    //메인(게임메니저에 플레이어 선택하기, 필드선택하기 )


}
