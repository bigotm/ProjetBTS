using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto
{

    class Cook:Personne
    {
        public Cook(string nom) : base(nom)
        {

        }

        public void OrderFood(Waiter unServeur)
        {
            Console.WriteLine("Le serveur a pris la nourriture à la cuisine");
            unServeur.Pickup();

        }
    }
}
