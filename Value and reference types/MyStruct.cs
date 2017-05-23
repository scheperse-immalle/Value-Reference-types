using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_reference_types
{
    struct MyStruct
    {
        public string Beschrijving;
        public int Hoeveelheid;
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
