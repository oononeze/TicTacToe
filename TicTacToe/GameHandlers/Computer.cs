using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IGameHandlers;

namespace GameHandlers
{
    class Computer : IComputer
    {
        public string Name { set; get; }

        public int Wins { get; set; }
    }
}
