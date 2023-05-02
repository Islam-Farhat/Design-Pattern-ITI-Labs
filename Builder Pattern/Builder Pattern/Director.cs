using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder_Pattern
{
    internal class Director
    {
        public void Construct(IBuilder builder)
        {
            builder.BuildPartA();
            builder.BuildPartB();
        }
    }
}
