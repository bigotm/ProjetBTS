using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace resto
{
    class Program
    {
        static void Main(string[] args)
        {
            Cashier michel = new Cashier("Luigi");
            Cook louis = new Cook("Louis");
            Client c = new Client("Roger");
            Waiter w = new Waiter(louis,michel,"michel");
            c.SeatAtTable(w);

            Console.ReadLine();
           
       
        }
    }
}
