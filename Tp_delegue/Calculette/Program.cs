using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculatrice c = new Calculatrice();

            c.ChoixOperation(Choix.Addition);
            c.ChoixOperation(Choix.Soustraction);

            c.Add(5);
            c.Add(3);
            c.Add(2);

            Console.WriteLine(c.Calculer());

            Console.ReadLine();
        }
    }
}
