using System;
using System.Collections.Generic;

namespace ExemplePOO
{
    public class Proprietaire
    {
        public string nom;
        public string prenom;
        public Bien[] biens = new Bien[0];


        public Proprietaire(string nom, string prenom, Bien[] biens)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.biens = biens;
        }

        private string ListeBiens()
        {
            string listeBiens = "";
            foreach (Bien B in biens)
            {
                listeBiens += String.Format("- {0} {1} au {2}\n", B.GetType().Name == "Maison" ? "Une" : "Un", B.GetType().Name, B.Adresse);
            }
            return listeBiens;
        }

        public override string ToString()
        {
            string toString = String.Format("{1} {0} {2}", nom, prenom, biens?.Length != 0 ? "possède\n" : "ne possède aucun bien");
            toString += ListeBiens();
            return toString;
        }
    }
}

