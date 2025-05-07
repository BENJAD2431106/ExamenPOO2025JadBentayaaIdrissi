using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO2025
{
    public class Embarcation
    {
        public string Nom {  get; set; }
        public int NbrePlaces { get; set; }
        public int Vitesse { get; set; }
        public int Confort {  get; set; }
        public double Poids { get; set; }

        protected Embarcation()
        {
            
        }
        protected Embarcation(string nom, int vitesse, int confort, int nbrePlaces, double poids)
        {
            Nom = nom;
            NbrePlaces = nbrePlaces;
            Vitesse=vitesse;
            Confort = confort;
            Poids = poids;
        }
        public override string ToString()
        {
            return  Nom + " -> Nombre de places : " + NbrePlaces + ", Vitese : " + Vitesse + ", Confort : " + Confort + " et poids : " + Poids;
        }
        public static bool operator <(Embarcation embarcation1, Embarcation embarcation2)
        {
            return embarcation1.Vitesse+embarcation1.Confort < embarcation2.Vitesse+embarcation2.Confort;
        }
        public static bool operator >(Embarcation embarcation1, Embarcation embarcation2)
        {
            return embarcation1.Vitesse + embarcation1.Confort > embarcation2.Vitesse + embarcation2.Confort;
        }
    }
}
