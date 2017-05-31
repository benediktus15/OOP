using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_OOP
{
    class FastInvader : Invader
    {
        protected virtual int stepsize { get; } = 1;
        public FastInvader(Path path) : base(path)
        {

        }

    }
}
