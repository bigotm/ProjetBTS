using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_Athlon
{
    class Participant
    {
        int id;
        string nom;
        DateTime dateInscription;

        List<Resultat> lesResultats;

        public Participant(int id, string nom, DateTime dateInscription)
        {
            this.id = id;
            this.nom = nom;
            this.dateInscription = dateInscription;
            this.lesResultats = new List<Resultat>();
        }
        public string GetNom()
        {
            return this.nom;
        }

        public DateTime GetDateInscripition()
        {
            return this.dateInscription;
        }

        private bool resultatPresent(Epreuve uneEpreuve)
        {
            foreach(Resultat res in lesResultats)
            {
                if (res.GetEpreuve.GetNom() == uneEpreuve.GetNom())
                {
                    return true;
                }
            }
            return false;
        }
        public void Add(Epreuve uneEpreuve,int tempsRealise)
        {
            if (resultatPresent(uneEpreuve) == false)
            {
                this.lesResultats.Add(new Resultat(this, uneEpreuve, tempsRealise));
            }
        }

        public int GetTempsTotal()
        {
            int tempsRealise = 0;
            foreach(Resultat r in lesResultats)
            {
                tempsRealise += r.GettempsRealise();
            }
            return tempsRealise;
        }

        public bool HorsDelai()
        {
            foreach(Resultat r in lesResultats)
            {

            }
        }
    }
}
