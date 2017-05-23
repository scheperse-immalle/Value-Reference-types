using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Value_and_reference_types
{
    //https://hackmd.io/AwJgRgJhwQbAtARgMYQJzwCwFY1ngIYgBmI8yxiAHIgVQOynbBA=?both	
    public class Program
    {
        public static void Main()
        {
            //value types
            int a = 3;
            long b = 3555555555555555555;
            byte c = 255;
            DateTime time = new DateTime();
            DateTime datum;

            // references 
            string str = "ik ben een string en een string is een reference type.";
            string naam;
            // een class ook

            // type

            Console.WriteLine(a.GetType());
            Console.WriteLine(b.GetType());
            Console.WriteLine(c.GetType());
            Console.WriteLine(time.GetType());
            Console.WriteLine(str.GetType());
            //Console.WriteLine(datum); --> foutmelding
            //Console.WriteLine(naam);  --> foutmelding

            // enkel hier fout melding; normaail is datum effectief een datum ook al is er niks geiniscialisseerd en bij 
            // string komt er gewoon null want dat is een reference.
            // datetime is een value (er is een value aan toegekent).

            // DO'S AND DONT'S https://msdn.microsoft.com/en-us/library/ms229031(v=vs.110).aspx
            MyClass mc = new MyClass();
            Console.WriteLine(mc);
            mc = new MyClass();
            Console.WriteLine(mc);


            MyStruct ms;
            Console.WriteLine(ms);


            MyClass mc1 = new MyClass();
            MyClass mc2 = new MyClass();
            MyClass mc3 = new MyClass() { Beschrijving = "mc3", Hoeveelheid = 4 };
            MyStruct ms1 = new MyStruct();
            MyStruct ms2 = new MyStruct();
            MyStruct ms3 = new MyStruct() { Beschrijving = "ms3", Hoeveelheid = 3 };

            Console.WriteLine(mc1.GetHashCode());
            Console.WriteLine(mc2.GetHashCode());
            Console.WriteLine(ms1.GetHashCode());
            Console.WriteLine(ms2.GetHashCode());


            
        }
    }

   
}
