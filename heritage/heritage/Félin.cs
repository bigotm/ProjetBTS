using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    class Félin:Mammifère
    {
        protected int nombrePattes;

        public Félin(int nombrePattes, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique) : base(nom,lieuHabitation,monCrie,jeSuisDomestique)
        {
            this.nombrePattes = nombrePattes;
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }
    }
}
