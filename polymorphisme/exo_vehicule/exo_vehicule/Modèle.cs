using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_vehicule
{
    class Modèle
    {
        string nom;
        double prix;
        List<Option> optionModèle = new List<Option>()  ; 

        public Modèle(string nom, double prix)
        {
            this.nom = nom;
            this.prix = prix;
            optionModèle = new List<Option>();
        }
        public double GetPrix
        {
            get { return prix; }
        }

        public void AddOption(Option option)
        {
            optionModèle.Add(option);
        }

        public Option this[int index]
        {
            get { return this.optionModèle[index]; }
        }
        public bool PossèdeOption(string libellé)
        {
            bool optio = false;
            foreach(Option option in optionModèle)
            {
                if (option.GetLibelle() == libellé)
                {
                    optio = true;
                }
            }
            return optio;

        }
        public int Count
        {
            get { return this.optionModèle.Count; }
        }

        public override string ToString()
        {
            string total="";
            for(int i =0;i<optionModèle.Count;i++)
            {
                total += optionModèle[i].ToString()+"\n";
            }
            return string.Format("Modele: {0} prix: {1} \n{2}",nom, prix,total);
            

        }
    }
}
