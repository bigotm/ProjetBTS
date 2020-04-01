using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correction_ctrl
{
    class Oeuvre
    {
        private string nom;
        private int prix;

        public Oeuvre(string nom, int prix)
        {
            this.nom = nom;
            this.prix = prix;
        }
        public string GetNOm()
        {
            return nom;
        }
    }
}
