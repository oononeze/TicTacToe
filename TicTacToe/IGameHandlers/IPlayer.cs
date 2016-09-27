using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IGameHandlers
{
    public interface IPlayer
    {
        string Name { set; get; }
        int Wins { get; set; }
        string Tag { get; set; }
    }
}
