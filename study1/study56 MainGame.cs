using System;
using System.IO;

namespace study56
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
                Console.WriteLine("==================");
                player.Render();
                Console.WriteLine("행동을 고르세요.");
                Console.WriteLine("1.사냥터 2.종료");
                int input = int.Parse(Console.ReadLine());

                if (input == 2)
                    break;

                if (input == 1)
                {
                    //필드 만들기기
                    if (field == null)
                    {
                        field = new Field();
                        // field.SetPlayer(player);
                    }
                    field.Progress();

                }
            }
        }
    }
}
