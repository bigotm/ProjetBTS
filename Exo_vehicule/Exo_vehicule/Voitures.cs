using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_vehicule
{
    class Voitures:Vehicule
    {
        protected bool decap;
        protected bool clim;

        public Voitures(bool decap, bool clim, string immatriculation, int anneeConstruc, string marque, string modele):base(string immatriculation, int anneeConstruc, string marque, string modele)
        {
            this.decap = decap;
            this.clim = clim;
        }
    }
}
