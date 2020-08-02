using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Fabrication
{
    class Board
    {
        private Square individualSquare;
        private static readonly Lazy<Board> boardInstance = new Lazy<Board>(() => new Board());
        public Square IndividualSquare
        {
            get => this.individualSquare;
            set => this.individualSquare = value;
        }


        public static Board BoardInstance
        {
            get
            {
                return boardInstance.Value;
            }
        }


        private Board()
        {
            Console.WriteLine("-----------------Board---------------------------------------------------");
            for (int i = 1; i <= 40; i++)
            {
                this.IndividualSquare = new Square($"Square: {i}");
            }



        }

        public Square GetSquare()
        {
            Console.WriteLine("Getting square location using face value total - {0}",this.IndividualSquare.SquareName);
            return this.individualSquare;

        }






    }
}
