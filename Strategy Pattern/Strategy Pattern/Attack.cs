using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern.Strategy_Pattern
{
    internal class Attack : ITeambeheviour
    {
        public void Play()
        {
            Console.WriteLine("I am playing as Attacker");
        }
    }
}
