using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docu
{
    class  Document
    {
        private string titre;
        private int duree;
        private bool enStock;
        private string commentaire;
        public Document(string titre, int duree, bool enStock, string commentaire)
        {
            this.titre = titre;
            this.duree = duree;
            this.enStock = enStock;
            this.commentaire = commentaire;
        }

        public void SetCommentaire(string commentaire)
        {
            this.commentaire = commentaire;
        }

        public string GetCommentaire()
        {
            return commentaire;
        }

        public void SetEnStock(bool enStock)
        {
            this.enStock = enStock;
        }

        public bool GetEnStock()
        {
            return enStock;
        }

        public void Afficher()
        {
            Console.WriteLine("document : "+titre+"("+duree+"mn)");
            if (enStock)
            {
                Console.WriteLine("Le document recherché est disponible");

            }
            else
            {
                Console.WriteLine("Document indisponible");
            }
            Console.WriteLine(" "+commentaire);
        }
    }
}
