using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    class Cétacé:Mammifère
    {
        protected int dureeApnee;
        protected int profondeurPlongee;

        public Cétacé(int dureeApnee, int profondeurPlongee, string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique) :base(nom,lieuHabitation,monCrie,jeSuisDomestique)
        {
            this.dureeApnee = dureeApnee;
            this.profondeurPlongee = profondeurPlongee;
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }
    }
}
