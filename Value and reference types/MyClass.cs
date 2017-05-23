using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_reference_types
{
    class MyClass
    {
        public string Beschrijving { get; set; }
        public int Hoeveelheid { get; set; }
        public override string ToString()
        {
            return string.Format("Beschrijving [{0}] - Hoeveelheid: [{1}]", Beschrijving, Hoeveelheid);
        }
    }
}
