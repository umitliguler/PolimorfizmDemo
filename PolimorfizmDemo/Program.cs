using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Bot bot = new Bot();
            Cizme cizme = new Cizme();

            AyakkabiKalibi ayakkabi1 = new Bot();
            AyakkabiKalibi ayakkabi2 = new Cizme();

            bot.SuGecirebilir = true;

            IAyakkabi iAyakkabi = new Bot();

        }
    }
}
