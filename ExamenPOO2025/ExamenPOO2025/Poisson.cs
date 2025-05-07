using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO2025
{
    public enum Diff
    {
        Facile, 
        Moyen,
        Difficile
    }
    public class Poisson
    {
        Random random = new Random();
        string Nom {  get; set; }
        public Diff Diff { get; set; }
        public int Force {  get; set; }
        public int Vitesse { get; set; }
        public int Poids { get; set; }
        public int Exp {  get; set; }
        public Poisson()
        {
            Diff[] tabDifficulte = {Diff.Facile, Diff.Moyen, Diff.Difficile}; ;
            Diff=tabDifficulte[random.Next(tabDifficulte.Length)];
            CalculerPropriete();
        }
        public void CalculerPropriete()
        {
            string[] noms = { "Doré", "Brochet", "Morue", "Sébaste", "Truite", "Perchaude" };
            if(Diff==Diff.Facile)
            {
                Exp = random.Next(2, 11);
                Force = 3;
                Vitesse = random.Next(2, 5);
            }
            else if(Diff==Diff.Moyen)
            {
                Exp = random.Next(11, 21);
                Force = 4;
                Vitesse = random.Next(5,9);
            }
            else if(Diff== Diff.Difficile)
            {
                Exp = random.Next(20, 51);
                Force = 5;
                Vitesse = random.Next(9, 11);
            }

            Nom = noms[random.Next(noms.Length)];
            Poids = Exp * 2;
        }

        public override string ToString()
        {
            return "Poisson -> " + Nom + " Poids : " + Poids + " Expérience : " + Exp + " vitesse : " + Vitesse + " Force : " + Force + " " + Diff + " à pêcher...";
        }
    }
}
