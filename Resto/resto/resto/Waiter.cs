using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto
{
    class Waiter:Personne
    {
        private Client monClient;
        private Cook monCuisinier;
        private Cashier leCaissier;

        public Waiter(Cook leCuisiner, Cashier leCaissier,string nom) : base(nom)
        {
            this.monCuisinier = leCuisiner;
            this.leCaissier = leCaissier;
        }
        public void OrderFood(Client unClient)
        {
            Console.WriteLine("Le serveur prend la commande");
            this.monClient = unClient;
            this.monCuisinier.OrderFood(this);

        }

        public void Pickup()
        {
            Console.WriteLine("Le serveur sert la nourriture");
            this.monClient.ServeFood(leCaissier);

        }
    }
}
