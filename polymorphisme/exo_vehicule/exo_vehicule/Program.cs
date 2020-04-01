using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_vehicule
{
    class Program
    {
        static void Main(string[] args)
        {
            Option o1 = new Option("Direction Assistée", 250);
            Option o2 = new Option("Air Bag", 320);
            Option o3 = new Option("CD audio", 230);
            Option o4 = new Option("Air Conditionné", 395);
            Modèle m = new Modèle("Clio", 12000);
            Modèle m2 = new Modèle("Lamborghini urus", 265000);
            m.AddOption(o1);
            m.AddOption(o2);
            Option o5 = new Option("nitro", 50000);
            Vehicule v2 = new Voiture(m, "lupo357");
            v2.AddOption(o5);
            Console.WriteLine(v2.possèdeOption(o5.GetLibelle()));
            Vehicule v = new Voiture(m, "474QQ95");
            v.AddOption(o3);
            v.AddOption(o4);
            Console.WriteLine(v.ToString());
            Console.ReadLine();
        }
    }
}
