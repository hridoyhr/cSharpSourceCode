using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSourceCode
{
    public class Book : Products
    {
        public string Author { get; set; }

        public override string FormatPrice()
        {
            return $"Tk. {_price}";
        }

    }
}
