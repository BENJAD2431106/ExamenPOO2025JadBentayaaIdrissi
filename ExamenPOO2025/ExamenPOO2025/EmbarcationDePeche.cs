using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO2025
{
    public class EmbarcationDePeche : Embarcation
    {
        public EmbarcationDePeche() : base()
        {
            Nom = "PêcheDefault";
            Random random = new Random();
            Vitesse = random.Next(4, 10);
            Confort = random.Next(4, 10);
            Poids = random.Next(150, 301);
            NbrePlaces = 8;
        }
        public EmbarcationDePeche(string nom, int vitesse, int confort, int nbrePlaces, double poids) : base(nom, vitesse, confort, nbrePlaces, poids)
        {
            Nom = nom;
            Vitesse = vitesse;
            Confort = confort;
            Poids = poids;
            NbrePlaces = nbrePlaces;
        }
        public override string ToString()
        {
            return "Embarcation De Pêche : " + base.ToString();
        }
    }
}
