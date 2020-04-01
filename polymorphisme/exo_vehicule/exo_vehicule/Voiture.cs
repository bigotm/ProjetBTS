using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_vehicule
{
    class Voiture:Vehicule
    {
        Modèle posseder;
        public Voiture(Modèle posseder,string immatriculation):base(immatriculation)
        {
            this.posseder = posseder;

        }
        public double CalculerPrix()
        {
            double total=posseder.GetPrix;
            for(int i = 0; i < posseder.Count; i++)
            {
                total = total + posseder[i].GetPrix();
            }
            for (int i = 0; i < base.Count; i++)
            {
                total = total + base[i].GetPrix();
            }

            return total;




        }
        public override string ToString()
        {
            return string.Format("{0}{1}Prix total: {2}", posseder.ToString(),base.ToString(),this.CalculerPrix());
        }

    }
}
