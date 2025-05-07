using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO2025
{
    public class EmbarcationPneumatique : Embarcation
    {
        public EmbarcationPneumatique():base()
        {
            Nom = "PneumatiqueDefault";
            Random random = new Random();
            Vitesse = random.Next(1, 8);
            Confort = random.Next(1, 8);
            Poids = random.Next(80, 151);
            NbrePlaces = 5;
        }
        public EmbarcationPneumatique(string nom, int vitesse, int confort, int nbrePlaces, double poids) : base(nom, vitesse, confort, nbrePlaces, poids)
        {
            Nom=nom;
            Vitesse = vitesse;
            Confort = confort;
            Poids = poids;
            NbrePlaces=nbrePlaces;
        }
        public override string ToString()
        {
            return "Embarcation Pneumatique : "+base.ToString();
        }
    }
}
