using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    internal class Forward : PlayerRoleDecorator
    {
        public Forward(ComponentPlayer player) : base(player)
        {
        }

        public override void PassBall()
        {
            _player?.PassBall();
            ShotGoal();
        }

        public void ShotGoal()
        {
            Console.WriteLine("ShotGoal");
        }
    }
}
