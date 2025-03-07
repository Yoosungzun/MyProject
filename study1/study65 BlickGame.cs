using System;
using System.Runtime.InteropServices;


namespace BlickGame
{
    class Program
    {
        [DllImport("msvcrt.dll")]
        public static extern int _getch(); //c언어 함수 가져옴

        public static void gotoxy(int x, int y)
        {
            Console.SetCursorPosition(x, y);
        }
        static void Main(string[] args)
        {
            GmaeManager gm = new GmaeManager();
            gm.Initialize();

            int Curr = Environment.TickCount;

            while (true)
            {
                if (Curr + 50 < Environment.TickCount)
                {
                    Curr = Environment.TickCount;

                    gm.Progress();
                    gm.Render();
                }
            }
        }
    }
}
