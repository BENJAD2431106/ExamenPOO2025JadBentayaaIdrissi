using ExamenPOO2025;
namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            EmbarcationDePeche embarcationDePeche = new EmbarcationDePeche("Embarcation1", 8, 8, 8, 190);
            EmbarcationPneumatique embarcationPneumatique = new EmbarcationPneumatique("Embracation2", 7, 5, 5, 85);
            Embarcation resuAttendu = embarcationPneumatique;
            Embarcation resuObtenu = PireEmbarcation(embarcationDePeche, embarcationPneumatique);
            Assert.Equal(resuAttendu, resuObtenu);
        }
        [Fact]
        public void Test2()
        {
            EmbarcationDePeche embarcationDePeche = new EmbarcationDePeche("Embarcation1", 8, 8, 8, 190);
            EmbarcationPneumatique embarcationPneumatique = new EmbarcationPneumatique("Embracation2", 7, 5, 5, 85); 
            Embarcation resuAttendu = embarcationDePeche;
            Embarcation resuObtenu = MeilleureEmbarcation(embarcationDePeche, embarcationPneumatique);
            Assert.Equal(resuAttendu, resuObtenu);
        }
        public Embarcation MeilleureEmbarcation(Embarcation embarcation1, Embarcation embarcation2)
        {
            Embarcation meilleure = null;
            if (embarcation1 > embarcation2)
            {
                return embarcation1;
            }
            else
                return embarcation2;
        }
        public Embarcation PireEmbarcation(Embarcation embarcation1, Embarcation embarcation2)
        {
            Embarcation meilleure = null;
            if (embarcation1 < embarcation2)
            {
                return embarcation1;
            }
            else
                return embarcation2;
        }
    }
}