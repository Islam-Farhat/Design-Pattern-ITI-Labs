using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    internal class Position
    {
        public int x { get; set; }
        public int y { get; set; }
        public int z { get; set; }
        public override string ToString()
        => $"X: {x}, Y: {y}, Z: {z}";
    }
}
