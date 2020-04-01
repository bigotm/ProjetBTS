using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Docu
{
    class Program
    {
        static void Main(string[] args)
        {
            Document F = new Document("into the wild", 124, true, "super film");
            F.Afficher();
            Video v = new Video("tarentino", "les huit salopard", 150, true, "Super film");
            v.Afficher();
            Console.ReadLine();
        }
    }
}
