using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO2025
{
    public class Pecheur
    {
        public string Nom {  get; set; }
        public int Exp { get; set; }
        public Poisson Poisson { get; set; }
        public CanneAPeche CanneAPeche { get; set; }
        public Pecheur()
        {
            Poisson = null;
            Exp = 100;
            Nom = "Pêcheur/Programmeur Vincent";
        }
        public double GetNiveau()
        {
            double niv = Exp / 100;
            double niveau = Math.Round(niv, 0);
            return niveau;
        }

        public string GetInfosPoisson()
        {
            string info ="";
            if (Poisson == null)
            {
                info = "Pas de poisson pour l'instant";
            }
            else
                info = Poisson.ToString();

            return info;
        }
        public override string ToString()
        {
            return Nom + " ---> Expérience : "+Exp+" et poisson ---> "+GetInfosPoisson();
        }
    }
}
