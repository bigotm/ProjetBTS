using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_vehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicule[] Tab = new Vehicule[4];
            Tab[0] = new Voiture("333 ABC 06", 2000, "peugot", "306", true, false);
            Tab[1] = new Voiture("321 BBD 06", 2001, "renault", "clio", false, true);
            Tab[2] = new CCamion("1234 TZ 06", 1993, "DAF", "T43",false,4);
            Tab[3] = new Voiture("765 ACE 06", 1999, "Mercedes", "C.L", false,3);        }
    }
}
