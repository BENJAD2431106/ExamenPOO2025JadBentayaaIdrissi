namespace ExamenPOO2025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Poisson poisson = new Poisson();
            //Console.WriteLine(poisson);
            //Pecheur pecheur = new Pecheur();
            //Console.WriteLine(pecheur);
            //Console.WriteLine("Niveau : "+pecheur.GetNiveau());
            //Console.WriteLine("MODIFICATION");
            //pecheur.Exp = 550;
            //Console.WriteLine(pecheur);
            //Console.WriteLine("Niveau : "+pecheur.GetNiveau());

            Simulateur simu = new Simulateur();
            simu.AfficherMenu();
        }
    }
}
