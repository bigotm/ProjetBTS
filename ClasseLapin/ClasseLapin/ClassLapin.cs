using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasseLapin
{
    public class Lapin
    {
        static private int comptage;
        private int dossard;
        static private Random aleatoire;
        private string surnom;
        private int age;
        private int position;
        private static int pas;

        static Lapin()
        {
            Lapin.comptage=100;
            Lapin.pas = 10;
        }


        public Lapin(string surnom, int age)
        {
           Lapin.aleatoire=  new Random();
            this.surnom = surnom;
            this.age = age;
            this.position = 0;
            this.dossard = Lapin.comptage + Lapin.pas;
            Lapin.comptage = Lapin.comptage + Lapin.pas;
        }

        public static void ChangeStart(int start)
        {
            Lapin.comptage = start;
        }
        public void Avancer()
        {            
            int nb;
            nb = aleatoire.Next(0, 5);
            position = position + nb;
        }


        public int Dossard
        {
            get { return this.dossard; }
            set{ this.dossard = value; }
        }
        public string Surnom
        {
            get
            {
                return this.surnom;
            }
            set
            {
                this.surnom = value;
            }
          
        }
        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }
        public int Position
        {
            get
            {
                return this.position;
            }
        }
        public string ToString()
        {
            return String.Format(" Le lapin {0} a {1} ans est a la position {2} et le dossard n°{3} ", surnom, age, position,dossard);
 
        }

    }
}
