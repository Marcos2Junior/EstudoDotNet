using System;
using System.Collections.Generic;
using System.Text;

namespace DP2_ConsoleApp1.cap2
{
    public class Piano
    {
        public void Toca(IList<INota> musica)
        {
            foreach (INota nota in musica)
            {
                Console.Beep(nota.Frequencia, 400);
            }
        }
    }
}
