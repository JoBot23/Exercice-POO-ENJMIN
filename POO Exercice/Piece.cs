using System;
using System.Text.RegularExpressions;

namespace ExemplePOO
{
    public class Piece
    {
        public int superficie;
        public string nom;

        public Piece(int superficie, string nom)
        {
            this.superficie = superficie;
            this.nom = nom;
        }

        public override string ToString()
        {
            return $"La pièce {nom} fait {superficie}m²";
        }
    }
}


