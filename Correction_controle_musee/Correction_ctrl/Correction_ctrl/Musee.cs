using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correction_ctrl
{
    class Musee
    {
        private string nom;
        List<Salle> lesSalles = new List<Salle>();

        public bool ChangerSalle(Oeuvre uneOeuvre ,Salle salleDestination)
        {
            bool changerSalle = true;
            if (salleDestination.Sallepleine() == true)
            {
                changerSalle = false;

            }
            else
            {
                if (lesSalles[OuSeTrouve(uneOeuvre)] == salleDestination)
                {
                    changerSalle = false;
                }
                else
                {
                    if (OuSeTrouve(uneOeuvre) == -1)
                    {
                        changerSalle = false;
                    }
                }
            }
            return changerSalle;
        }

        public int OuSeTrouve(Oeuvre uneOeuvre)
        {
            foreach(Salle )
            {

            }

        }
    }
}
