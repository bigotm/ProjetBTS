using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto
{
    class Cashier:Personne
    {
        public Cashier(string nom) : base(nom)
        {

        }
        public void Pay()
        {
            Console.WriteLine("La caissière vous remercie de votre visite");
        }
    }
}
