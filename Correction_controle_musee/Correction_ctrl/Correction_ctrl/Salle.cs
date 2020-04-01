using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correction_ctrl
{
    class Salle
    {
        private int capaciteSalle;
        private string nom;
        List<Oeuvre> lesOeuvres = new List<Oeuvre>();
        public Salle(int capaciteSalle, string nom)
        {
            this.capaciteSalle = capaciteSalle;
            this.nom = nom;
        }

        public bool Sallepleine()
        {
            int nbOeuvre = lesOeuvres.Count;
            if (nbOeuvre < this.capaciteSalle)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool EstPresente(Oeuvre uneOeuvre)
        {
            for(int i = 0; i < lesOeuvres.Count; i++)
            {
                if (lesOeuvres[i].GetNOm() == uneOeuvre.GetNOm())
                {
                    return true;
                }
            }
        }
    }
}
