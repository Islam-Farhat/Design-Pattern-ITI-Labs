using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder_Pattern
{
    internal class BuilderMulti : IBuilder
    {
        public Product _product = new();
        public BuilderMulti()
        {

        }

        public void BuildPartA()
        {
            _product.Add("Multi BuildPartsA");
        }

        public void BuildPartB()
        {
            _product.Add("Multi BuildPartsB");
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
