using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClasseLapin;

namespace ClasseLapin
{
    class Program
    {
        static void Main()
        {
            Lapin.ChangeStart(200);
            Course marathon = new Course(42);
            marathon.Add(new Lapin("jeannot", 2));
            marathon.Add(new Lapin("panpan", 6));
            marathon.Add(new Lapin("jelly", 5));

            marathon.Départ();

            foreach(Lapin l in marathon.Participer)
            {
                Console.WriteLine(l.ToString());
            }

            Lapin andTheWinnerIs = marathon.Gagnant();
            Console.WriteLine("Le grand gagnant est : {0}", andTheWinnerIs.Surnom);
            Console.ReadLine();

        }    
    }
}
