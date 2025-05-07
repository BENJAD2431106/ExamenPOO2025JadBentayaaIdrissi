using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamenPOO2025
{
    public class Simulateur
    {
        Random random = new Random();
        Pecheur Pecheur { get; set; }
        List<Embarcation> Embarcations { get; set; }
        List<Poisson> Poissons { get; set; }
        CanneAPeche Canne { get; set; }
        Embarcation Embarcation { get; set; }
        public Simulateur()
        {
            Pecheur = new Pecheur();
            Embarcations = CreerLesEmbarcations();
            Embarcation = ChoisirLaMeilleure(Embarcations);
            Canne = new CanneAPeche("Samsung",10,10); //pas d'idée de marque lol
            Pecheur.CanneAPeche = Canne;
            Poissons = new List<Poisson>();
        }
        private string GetInfosEmbarcations()
        {
            string infos = "";
            foreach (Embarcation embarcation in Embarcations)
            {
                infos += embarcation.ToString() + "\n";
            }
            infos += "Le simulateur vous a choisi l'embarcation : " + Embarcation.ToString();
            return infos;
        }
        private List<Embarcation> CreerLesEmbarcations()
        {
            List<Embarcation> embarcations = new List<Embarcation>();
            for (int i = 0; i < 5; i++)
            {
                int rnd = random.Next(1, 3);
                if (rnd == 1)
                {
                    EmbarcationDePeche embarcationDePeche = new EmbarcationDePeche();
                    embarcations.Add(embarcationDePeche);
                }
                else
                {
                    EmbarcationPneumatique embarcationPneumatique = new EmbarcationPneumatique();
                    embarcations.Add(embarcationPneumatique);
                }
            }
            return embarcations;
        }
        private Embarcation ChoisirLaMeilleure(List<Embarcation> embarcations)
        {
            Embarcation laMeilleure = embarcations[0];
            foreach (Embarcation emb in embarcations)
            {
                if (emb > laMeilleure)
                { laMeilleure = emb; }
            }
            return laMeilleure;
        }
        //private Poisson MeilleurPoisson(List<Poisson> poissons)
        //{
        //    Poisson meilleur = poissons[0];
        //    foreach (Poisson poiss in poissons)
        //    {
        //        if (poiss.Force + poiss.Vitesse >= meilleur.Force + meilleur.Vitesse)
        //        {
        //            meilleur = poiss;
        //        }
        //    }
        //    return meilleur;
        //}
        private void SimulerPeche()
        {
            List<Poisson> poissons = new List<Poisson>();
            Poisson poisson = new Poisson();
            poissons.Add(poisson);
            int valPecheur = random.Next(1, Pecheur.CanneAPeche.Resistance) + random.Next(1, Pecheur.CanneAPeche.Flexibilite);
            int valPoisson = poisson.Force + poisson.Vitesse;
            if (valPecheur >= valPoisson)
            {
                Console.WriteLine(poisson.Poids + " réussi à etre pêché.");
                if(Pecheur.Poisson is null)
                {
                    Pecheur.Poisson = poisson;
                }
                else
                {
                    if (Pecheur.Poisson.Force+Pecheur.Poisson.Vitesse < valPoisson)
                    {
                        Pecheur.Poisson = poisson;
                    }
                }
                Pecheur.Exp += poisson.Exp;
            }
            else
                Console.WriteLine("\npoisson " + poisson + " s'est échappé...");
        }
        private double CalculerMoyenne()
        {
            double poids = 0;
            double moy = 0;
            foreach (Poisson p in Poissons)
            {
                poids += p.Poids;
            }
            moy = poids / Poissons.Count;
            return moy;
        }
        public void AfficherMenu()
        {
            bool quitter = false;
            Console.WriteLine("**********************************Bienvenue dans le simulateur de pêche crér pas Jad :*************************");
            Console.WriteLine(GetInfosEmbarcations());
            Console.WriteLine("Bonjour Vincent, vous pouvez : ");
            do
            {
                try
                {
                    Console.WriteLine("1- Afficher informations du pêcheur et de son poisson.\n2- Afficher les informations de l'embarcation du pĉheur.\n3- Afficher les informations de la canne à pêche.\n4- Simuler la capture d'un poisson*.\n5- Afficher la moyenne des poids des poissons*.\n6- Quitter ...");
                    int choix = int.Parse(Console.ReadLine());
                    if (choix == 6)
                    {
                        quitter = true;
                        Console.WriteLine("Vous avez quitté !");
                    }
                    else if (choix == 1)
                    {
                        Console.Clear();
                        Console.WriteLine(Pecheur);
                    }
                    else if (choix == 2)
                    {
                        Console.Clear();
                        Console.WriteLine(Embarcation);
                    }
                    else if (choix == 3)
                    {
                        Console.Clear();
                        Console.WriteLine(Pecheur.CanneAPeche);
                    }
                    else if (choix == 4)
                    {
                        Console.Clear();
                        SimulerPeche();
                    }
                    else if (choix == 5)
                    {
                        Console.WriteLine(CalculerMoyenne()+" est la moyenne des poids."); 
                    }
                    if (choix != 1 && choix != 2 && choix != 3 && choix != 4 && choix != 5 && choix != 6)
                    {
                        throw new Exception ("Entrée invalide !");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!quitter);
        }
    }
}
