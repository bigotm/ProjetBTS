using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage
{
    class Mammifère
    {
        protected string nom;
        protected string lieuHabitation;
        protected string monCrie;
        protected bool jeSuisDomestique;
        protected bool jeSuisDangereux;
        public Mammifère(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }

        protected bool JeSuisDangereux
        {
            
                
        }

       
    }
}
