using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolimorfizmDemo
{
    class Bot : AyakkabiKalibi, IAyakkabi
    {
        public bool SuGecirebilir { get; set; }
    }
}
