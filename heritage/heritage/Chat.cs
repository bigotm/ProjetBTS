using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    class Chat : Félin
    {
        public Chat(int nombrePattes, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique) : base(nombrePattes,nom, lieuHabitation, monCrie, jeSuisDomestique)
        {

        }
        public void Afficher()
        {
            Console.WriteLine("mon nom est {0} mon lieu d'ahabitation est {1} mon crie est {2} et je suis {3}");
        }
    }
}
