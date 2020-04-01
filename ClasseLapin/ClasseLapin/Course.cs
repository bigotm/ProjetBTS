using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseLapin
{
    class Course
    {
        private int distance;
        private List<Lapin> participer;

        public void Add(Lapin nouveauParticipant)
        {
            this.participer.Add(nouveauParticipant);
        }

        public Course(int distance)
        {
            this.distance = distance;
            this.participer = new List<Lapin>();
        }

        public void Départ()
        {
            for(int i = 0; i<this.Count; i++)
            {
                while (participer[i].Position< this.distance)
                {
                    participer[i].Avancer();
                }
            }
        }

        public Lapin Gagnant()
        {
            Lapin gagnant=null;
            for (int i=1; i<participer.Count; i++)
            {
                if (participer[i - 1].Position > participer[i].Position)
                {
                    gagnant = participer[i-1];
                }
            }
            return gagnant;

        }










































        public List<Lapin> GetParticiper()
        {
            return this.participer;

        }

        public void RemoveAt(int position)
        {
            this.participer.RemoveAt(position);

        }

        public int Count
        {
            get
            {
                return participer.Count;
            }
         
        }

        public List<Lapin> Participer
        {
            get
            {
                return participer;
            }
        }

        public Lapin this[int position]
        {
            get
            {
                return this.participer[position];
            }
        }
    }
}
