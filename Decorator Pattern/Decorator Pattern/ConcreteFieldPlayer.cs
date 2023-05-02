using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern.Decorator_Pattern
{
    internal class ConcreteFieldPlayer : ComponentPlayer
    {
        public void PassBall()
        {
            Console.WriteLine("FieldPlayer");
        }
    }
}
