using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Fabrication
{
    class Square
    {
        private string squareName;
        public string SquareName
        {
            get => this.squareName;
            set => this.squareName = value;
        }



        private Piece individualPiece;
        public Piece IndividualPiece
        {
            get => this.individualPiece;
            set => this.individualPiece = value;
        }

        public Square(string squareName)
        {
            this.SquareName = squareName;
            //Console.WriteLine("{0}", this.SquareName);
            for (int i = 1; i <= 8; i++)
            {
                this.IndividualPiece = new Piece($"Piece: {i}");
            }
        }

        public Piece LandedOn(Piece piece)
        {
            this.IndividualPiece = piece;
            Console.WriteLine("Player landed on {0} on the {1}",this.IndividualPiece.PieceName,this.SquareName);
            return piece;
        }
    }
}
