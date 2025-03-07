using System;
using System.Runtime.InteropServices;


namespace BlickGame
{
    class GmaeManager
    {
        Ball m_pBall = null;

        public void Initialize()
        {
            if (m_pBall == null)
            {
                m_pBall = new Ball();
                m_pBall.Initialize();
            }
        }

        public void Progress()
        {
            m_pBall.Progress();
        }

        public void Render()
        {
            Console.Clear();
            m_pBall.Render();
        }

        public void Release()
        {
            m_pBall.Release();
        }


    }
}
