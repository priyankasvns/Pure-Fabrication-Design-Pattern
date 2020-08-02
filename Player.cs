using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Fabrication
{
    class Player
    {
        private string playerName;
        

        public string PlayerName
        {
            get => this.playerName;
            set => this.playerName = value;
        }

        private Cup cupToRoll = new Cup();
        public Cup CupToRoll
        {
            get => this.cupToRoll;
            set => this.cupToRoll = value;
        }

        public void takeTurn()
        {
            Console.WriteLine("Rolling die using cup which is the fabricated class!");
            cupToRoll.RollDie();
            Console.WriteLine("Getting the total face value using getTotalFaceValue() method in cup class!");
            cupToRoll.GetTotalFaceValue();

            Piece piece = new Piece("Piece 30");
            Console.WriteLine("Player fetching sqaure location and its name is {0}",Board.BoardInstance.GetSquare().SquareName);
            Console.WriteLine("Player landed the piece on : {0}", Board.BoardInstance.IndividualSquare.LandedOn(piece).PieceName);
        }
    }
}
