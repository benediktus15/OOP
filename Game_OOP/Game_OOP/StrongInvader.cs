using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_OOP
{
    class StrongInvader : Invader
    {
        public override int Health { get; protected set; } = 3;

        public StrongInvader(Path path) : base(path)
        {

        }
    }
}
