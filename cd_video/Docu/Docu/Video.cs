using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docu
{
    class Video:Document
    {
        private string metteurEnScene;

        public Video(string metteurEnScene, string titre, int duree, bool enStock, string commentaire):base( titre,  duree, enStock,  commentaire)
        {
            this.metteurEnScene = metteurEnScene;
        }

        public void Afficheur()
        {
            Console.WriteLine("   " + metteurEnScene);


        }
    }
}
