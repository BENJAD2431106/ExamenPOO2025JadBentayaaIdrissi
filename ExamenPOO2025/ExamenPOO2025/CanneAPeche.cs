using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO2025
{
    public class CanneAPeche
    {
        string Marque { get; set; }
        public int Flexibilite { get; set; }
        public int Resistance { get; set; }
        public CanneAPeche(string marque)
        {
            Random random = new Random();
            Flexibilite = random.Next(1, 11);
            Resistance = random.Next(1, 11);
            Marque = marque;
        }
        public CanneAPeche(string marque, int flex, int res)
        {
            Random random = new Random();
            Flexibilite = flex;
            Resistance = res;
            Marque = marque;
        }
        public override string ToString()
        {
            return " Canne à pêche " + Marque + " de résistance " + Resistance + " et de flexibilité " + Flexibilite;
        }
    }
}
