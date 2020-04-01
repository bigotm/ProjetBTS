using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_Athlon
{
    class Resultat
    {
        Participant unParticpant;
        Epreuve uneEpreuve;
        int tempsRealise;

        public Resultat(Participant unParticipant,Epreuve uneEpreuve,int tempsRealise)
        {
            this.unParticpant = unParticpant;
            this.uneEpreuve = uneEpreuve;
            this.tempsRealise = tempsRealise;
        }

        public Epreuve GetEpreuve()
        {
            return this.uneEpreuve;
        }

        public int GettempsRealise()
        {
            return this.tempsRealise;
        }
    }
}
