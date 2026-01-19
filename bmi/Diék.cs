using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bmi
{
    public class Diék
    {
        public String Név { get; set; }

        public int Életkor { get; set; }

        public int Magasság { get; set; }

        public int Testsúly { get; set; }

    public Diék(string név, int életkor, int magasság, int testsúly)
        {
            Név = név;
            Életkor = életkor;
            Magasság = magasság;
            Testsúly = testsúly;
        }

        public override string ToString()
        {
            return $"{Név} {Életkor}éves {Magasság}cm {Testsúly}kg";
        }
    }
}
