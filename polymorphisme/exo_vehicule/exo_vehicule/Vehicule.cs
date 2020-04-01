using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exo_vehicule
{
    abstract class Vehicule
    {
        List<Option> optionBase = new List<Option>();
        string immatriculation;
        public Vehicule(string immatriculation)
        {
            this.immatriculation = immatriculation;
        }
        public void AddOption(Option option)
        {
            optionBase.Add(option);
        }
        public bool possèdeOption(string libellé)
        {
            for (int i = 0; i < optionBase.Count; i++)
            {
                Option opt = optionBase[i];
                if (libellé == opt.GetLibelle())
                {
                    return true;
                }
            }
            return false;

        }

        public Option this[int index]
        {
            get
            {
                return this.optionBase[index];
            }
        }
        public int Count
        {
            get
            {
                return this.optionBase.Count;
            }
        }
        public override string ToString()
        {
            string total = "";
            for (int i = 0; i < optionBase.Count; i++)
            {
                total += optionBase[i].ToString() + "\n";
            }
            return string.Format("Vehicule: {0} \n{1}", immatriculation, total);
        }
    }
}
