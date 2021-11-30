using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSourceCode
{
    public class Electronics : Products
    {
        public string BrandName { get; set; }

        public override double CalculateDiscount()
        {
            return _price * 25 / 100.0;
        }
    }
}
