using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_Pattern.Builder_Pattern
{
    internal class BuilderSingle : IBuilder
    {
        public Product _product = new();
        public BuilderSingle()
        {
            
        }

        public void BuildPartA()
        {
            _product.Add("Single BuildPartsA");
        }

        public void BuildPartB()
        {
            _product.Add("Single BuildPartsB");
        }

        public Product GetResult()
        {
            return _product;
        }
    }
}
