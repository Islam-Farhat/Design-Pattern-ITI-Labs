using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    internal abstract class PlayerRoleDecorator : ComponentPlayer
    {
        protected ComponentPlayer? _player;
        public PlayerRoleDecorator(ComponentPlayer player)
        {
            this._player = player;
        }
        public abstract void PassBall();
        public void AssignPlayer(ComponentPlayer? player)
        {
           this._player= player;
        }
    }
}
