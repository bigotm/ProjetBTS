using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Docu
{
    class Database
    {
        ArrayList lesDocuments = new ArrayList();      

        public void Add(Document d)
        {
            lesDocuments.Add(lesDocuments);
        }

        public void Editer()
        {
            for(int i = 0; i < lesDocuments.Count; i = i++)
            {
                Document d = (Document)lesDocuments[i];
                d.Afficher();
            }
        }
    }
}
