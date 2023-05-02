using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    internal class Defender : PlayerRoleDecorator
    {
        public Defender(ComponentPlayer player) : base(player)
        {
        }
        public void Defend()
        {
            Console.WriteLine("Defend");
        }

        public override void PassBall()
        {
            _player?.PassBall();
            Defend();
        }
    }
}
