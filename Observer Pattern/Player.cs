using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Player : IObserver
    {
        public void Update()
        {
            Console.WriteLine("Update Player");
        }
    }
}
