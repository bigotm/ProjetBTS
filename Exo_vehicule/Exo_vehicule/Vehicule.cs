using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo_vehicule
{
    class Vehicule
    {
        protected string immatriculation;
        protected int anneeConstruc;
        protected string marque;
        protected string modele;
       
        public Vehicule(string immatriculation, int anneeConstruc, string marque, string modele)
        {
            this.immatriculation = immatriculation;
            this.anneeConstruc = anneeConstruc;
            this.marque = marque;
            this.modele = modele;
        }
    }
}
