using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docu
{
    class CD:Document
    {
        private string artiste;
        private int nombreDePistes;

        public CD(string artiste, int nombreDePistes ,string titre, int duree, bool enStock, string commentaire) :base( titre, duree, enStock, commentaire)
        {
            this.artiste = artiste;
            this.nombreDePistes = nombreDePistes;
        }

        public void Afficheur()
        {
            Console.WriteLine("   "+artiste);
            Console.WriteLine("   pistes : "+nombreDePistes);

        }
    }
}
