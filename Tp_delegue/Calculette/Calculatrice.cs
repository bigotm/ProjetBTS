using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculette
{
    class Calculatrice
    {
        delegate int PrototypeOperation(int j,int i);
        PrototypeOperation dOperation=null;
        List<int> lesNombres = new List<int>();
        public Calculatrice()
        {

        }

        public int Calculer()
        {
            int i = 1;
            int result = lesNombres[0];
            foreach(PrototypeOperation d in dOperation.GetInvocationList())
            {
                result = d.Invoke(result, lesNombres[i]);
                i++;
            }
            return result;
        }

        public void Add(int n)
        {
            lesNombres.Add(n);
        }
        public int Addition(int n1,int n2)
        {
       
            return n1 + n2;
        }

        public int Soustraction(int n1,int n2)
        {
            
            return n1 - n2;
        }

        public int Multiplication(int n1, int n2)
        {
            
            return n1 * n2;
        }

        public int Division(int n1, int n2)
        {
            if (n2 == 0)
            {
                throw new Exception("Division par 0 impossible");
            }
            return n1/n2;
        }

        public void ChoixOperation(Choix choix)
        {
            switch (choix)
            {
                case Choix.Addition:
                    dOperation += Addition;
                    break;
                case Choix.Soustraction:
                    dOperation += Soustraction;
                    break;
                case Choix.Multiplication:
                    dOperation += Multiplication;
                    break;
                case Choix.Division:
                    dOperation += Division;
                    break;




            }
        }
    }
}
