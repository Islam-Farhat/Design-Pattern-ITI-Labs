using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    internal class MidFielder : PlayerRoleDecorator
    {
        public MidFielder(ComponentPlayer player) : base(player)
        {
        }
        public void Dirbble()
        {
            Console.WriteLine("Dirbble");
        }

        public override void PassBall()
        {
            _player?.PassBall();
            Dirbble();
        }
    }
}
