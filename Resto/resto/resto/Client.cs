using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto
{
    class Client:Personne
    {
        string nom;

        public Client(string nom) : base(nom)
        {
            this.nom = nom;
        }
        public void SeatAtTable(Waiter unServeur)
        {
            Console.WriteLine("Les clients s'assoient à une table");
            unServeur.OrderFood(this);

        }
        public void ServeWine()
        {
            Console.WriteLine("Le serveur sert le vin");
        }

        public void ServeFood(Cashier leCaissier)
        {
            ServeWine();
            Console.WriteLine("Le serveur indique au client ou payer");
                       
            leCaissier.Pay();


        }


    }
}
