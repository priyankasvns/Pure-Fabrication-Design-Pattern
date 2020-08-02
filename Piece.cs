using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pure_Fabrication
{
    class Piece
    {
        private string pieceName;
        public string PieceName
        {
            get => this.pieceName;
            set => this.pieceName = value;
        }

        public Piece(string pieceName)
        {
            this.PieceName = pieceName;
            //Console.WriteLine("{0}", this.PieceName);
        }

    }
}
