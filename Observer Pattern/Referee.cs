using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Referee : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Update Referee");
        }

    }
}
