using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tri_Athlon
{
    class Tri
    {
        string nature;
        Epreuve natation;
        Epreuve velo;
        Epreuve course;
        List<Participant> lesParticipants;

        public Tri(string nature,int distanceNatation,int distanceVelo,int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("natation", distanceNatation);
            this.natation = new Epreuve("velo", distanceVelo);
            this.natation = new Epreuve("course", distanceCourse);
            List<Participant> lesParticipants = new List<Participant>();
        }
        public string GetNature()
        {
            return this.nature;
        }

        public void AddParticipants(Participant unParticipant)
        {
            this.lesParticipants.Add(unParticipant);

        }

        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return this.natation;
                case "vélo":
                    return this.velo;
                default:
                    return this.course;
            }
        }
        public Participant GetParticipantById(int id)
        {
            for (int i = 0; i < lesParticipants.Count; i++)
            {
                if (lesParticipants[i].GetId() == id)
                {
                    return lesParticipants[i];
                }
            }
            return null;
        }
        public int GetDistanceTotale()
        {
            int distTotal;
            distTotal = natation.GetDistance() + course.GetDistance() + velo.GetDistance();
            return distTotal;
        }

        public List<Participant> GetLesTemps()
        {
            List<Participant> P = new List<Participant>();
            for(int i = 0; i < lesParticipants.Count; i++)
            {
                if (lesParticipants[i].HorsDelai() == false)
                {
                    P.Add(lesParticipants[i]);
                }
            }
            return P;
        }

    }
}
