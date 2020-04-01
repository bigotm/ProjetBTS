using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Unitaires
{
    public class EAN13
    {
        private int[] ean13;

        public EAN13(int[] ean13)
        {
            if (ean13.Length != 12)
            {
                throw new Exception("Un code Ean 13 doit etre un tableau de 12 entiers");
            }
            this.ean13 = new int[13];
            for (int i = 0; i < 12; i++)
            {
                this.ean13[i] = ean13[i];
            }

        }

        public int PoidsPair()
        {
            int PP = 0;
            for(int i=0; i < ean13.Length; i++)
            {
                if(ean13[i] % 2 == 0)
                {
                    PP += ean13[i];
                }
            }

            return PP;
        }

        public int PoidsImpair()
        {
            int PI = 0;
            for (int i = 0; i < ean13.Length; i++)
            {
                if (ean13[i] % 2 != 0)
                {
                    PI += ean13[i];
                }
            }

            return PI;
        }

        public int Reste()
        {
            int poidsImpair = this.PoidsImpair();
            int poidsPair = this.PoidsPair();

            int somme = poidsImpair + poidsPair;
            int reste = somme % 10;
            return reste;
        }

        public int Cle()
        {
            int poidsImpair = this.PoidsImpair();
            int poidsPair = this.PoidsPair();

            int somme = poidsImpair + poidsPair;
            int reste = somme % 10;
            int cle = 10 - reste;
            return cle;
        }

        public override string ToString()
        {

            string s = "";
            return s;
        }

    }
}
