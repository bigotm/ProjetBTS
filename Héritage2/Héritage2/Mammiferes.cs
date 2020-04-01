using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Héritage2
{
    class Mammiferes
    {
        private string nom;
        private string lieuHabitation;
        private string monCrie;
        private bool jeSuisDomestique;

        public Mammiferes(string nom, string lieuHabitation, string monCrie, bool jeSuisDomestique)
        {
            this.nom = nom;
            this.lieuHabitation = lieuHabitation;
            this.monCrie = monCrie;
            this.jeSuisDomestique = jeSuisDomestique;
        }


    }
}
