using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Fabrication
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player();
            player1.takeTurn();

            Console.ReadLine();
        }
    }
}
