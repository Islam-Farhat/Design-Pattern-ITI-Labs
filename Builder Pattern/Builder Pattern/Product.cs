using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder_Pattern
{
    internal class Product
    {
        LinkedList<string> parts;
        public Product()
        {
            parts = new();
        }

        public void Add(string part)
        {
            parts.AddLast(part);
        }

        public string Display()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Product components are: ");
            foreach (string part in parts)
                sb.Append($"{part}  ");

            return sb.ToString();
        }
    }
}
