using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp_Diag_Seq
{
    public partial class Article
    {
        private string designation;
        private double prixHorsTaxe;
        private double tauxTva;


        public double GetPrixHorsTaxe
        {
            get {return prixHorsTaxe; }
            set { prixHorsTaxe = value; }
        }
        public string GetDesignation {
            get{return => designation;
            set => designation = value;
        }
    }
}
